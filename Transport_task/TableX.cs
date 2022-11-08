using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transport_task
{
    public partial class TableX : UserControl
    {
        private readonly int _tbWidth = 0;
        private readonly int _tbHeight = 0;
        private readonly int _tbTop = 0;
        private readonly int _tbLeft = 0;

        private Color _sidesColor = Color.FromArgb(211, 198, 185);

        private int _columns = 1;
        private int _rows = 1;

        public int Columns
        {
            get
            {
                return _columns;
            }
            set
            {
                if (value > _columns)
                {
                    for (int i = 0; i < _rows; i++)
                    {
                        for (int k = _columns; k < value; k++)
                        {
                            AddTextBox(k, i, $"tb{k}{i}", Color.White);

                            GetRes(i).Left += _tbWidth;

                            if (i == 0)
                                AddTextBox(k, _rows, $"req{k}", _sidesColor);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < _rows; i++)
                    {
                        for (int k = value; k < _columns; k++)
                        {
                            RemoveTextBox($"tb{k}{i}");

                            GetRes(i).Left -= _tbWidth;

                            if (i == 0)
                                RemoveTextBox($"req{k}");
                        }
                    }
                }

                _columns = value;
            }
        }

        public int Rows
        {
            get
            {
                return _rows;
            }
            set
            {
                if (value > _rows)
                {
                    for (int i = _rows; i < value; i++)
                    {
                        for (int k = 0; k < _columns; k++)
                        {
                            AddTextBox(k, i, $"tb{k}{i}", Color.White);

                            GetReq(k).Top += _tbHeight;
                        }
                        AddTextBox(_columns, i, $"res{i}", _sidesColor);
                    }
                }
                else
                {
                    for (int i = value; i < _rows; i++)
                    {
                        for (int k = 0; k < _columns; k++)
                        {
                            RemoveTextBox($"tb{k}{i}");

                            GetReq(k).Top -= _tbHeight;

                            if (k == 0)
                                RemoveTextBox($"res{i}");
                        }
                    }
                }

                _rows = value;
            }
        }
        
        public string this[int row, int column]
        {
            get
            {
                return GetEl(column, row).Text;
            }
            set
            {
                GetEl(column, row).Text = value;
            }
        }

        public TableX()
        {
            InitializeComponent();

            _tbWidth = tb00.Width;
            _tbHeight = tb00.Height;
            _tbTop = tb00.Top;
            _tbLeft = tb00.Left;
        }

        private void TableX_Load(object sender, EventArgs e)
        {

        }

        void AddTextBox(int x, int y, string name, Color color)
        {
            TextBox textBox = new TextBox()
            {
                Width = _tbWidth,
                Top = _tbTop + _tbHeight * y,
                Left = _tbLeft + _tbWidth * x,
                Visible = true,
                Name = name,
                BackColor = color
            };
            this.Controls.Add(textBox);
        }
        
        void RemoveTextBox(string name)
        {
            TextBox tb = this.Controls.Find(name, false)[0] as TextBox;
            tb.Dispose();
        }

        public TextBox GetReq(int k) => this.Controls.Find($"req{k}", false)[0] as TextBox;

        public TextBox GetRes(int k) => this.Controls.Find($"res{k}", false)[0] as TextBox;

        public TextBox GetEl(int x, int y) => this.Controls.Find($"tb{x}{y}", false)[0] as TextBox;





    }
}
