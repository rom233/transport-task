using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transport_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int m
        {
            get
            {
                return (int)inputRows.Value;
            }
            set
            {
                inputRows.Value = value;
            }
        }
        private int n
        {
            get
            {
                return (int)inputColumns.Value;
            }
            set
            {
                inputColumns.Value = value;
            }
        }


        private void inputColumnsRows_ValueChanged(object sender, EventArgs e)
        {
            tableX1.Rows = m;
            tableX1.Columns = n;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[m, n];
            int[] req = new int[n];
            int[] res = new int[m];

            for (int i = 0; i < m; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    matrix[i, k] = Int32.Parse(tableX1[i, k]);

                    if (i == 0)
                        req[k] = Int32.Parse(tableX1.GetReq(k).Text);
                }
                res[i] = Int32.Parse(tableX1.GetRes(i).Text);
            }

            // Этап 1. Поиск опорного плана (метод северо-западного угла)

            int[,] matrix_2 = new int[m, n];
            int[] req_2 = new int[n];
            int[] res_2 = new int[m];

            Array.Copy(req, req_2, req.Length);
            Array.Copy(res, res_2, res.Length);

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < m; k++)
                {
                    int min = res_2[k] < req_2[i] ? res_2[k] : req_2[i];

                    res_2[k] -= min;
                    req_2[i] -= min;

                    Console.Write($"{matrix[k, i]}({min})[{res_2[k]}/{req_2[i]}]  ");

                    matrix_2[k, i] = min;
                }
                Console.WriteLine();
            }

            int sum = 0;

            Console.Write("F(x) = ");
            for (int i = 0; i < m; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (matrix_2[i, k] <= 0) continue;

                    sum += matrix[i, k] * matrix_2[i, k];
                    
                    Console.Write($"{matrix[i, k]}*{matrix_2[i, k]} + ");
                }
            }
            Console.WriteLine($" = {sum}");

            // Этап 2. Улучшение опорного плана

            // Нахождение потенциалов

            int[] req_3 = new int[n];
            for (int i = 0; i < n; i++) req_3[i] = -1;
            int[] res_3 = new int[m];
            for (int i = 1; i < m; i++) res_3[i] = -1;

            for (int i = 0; i < m; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (matrix_2[i, k] <= 0) continue;

                    if (req_3[k] == -1 && res_3[i] != -1)
                        req_3[k] = matrix[i, k] - res_3[i];

                    if (res_3[i] == -1 && req_3[k] != -1)
                        res_3[i] = matrix[i, k] - req_3[k];
                }
            }

            for (int i = 0; i < m; i++) 
                Console.WriteLine($"u{i} = {res_3[i]}");

            for (int i = 0; i < n; i++) 
                Console.WriteLine($"v{i} = {req_3[i]}");

            bool flag = true;
            int max = -9999999;
            int pos_i = -1;
            int pos_k = -1;

            for (int i = 0; i < m; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (req_3[k] + res_3[i] > matrix[i, k])
                    {
                        int d = req_3[k] + res_3[i] - matrix[i, k];
                        flag = false;

                        if (d > max)
                        {
                            max = d;
                            pos_i = i;
                            pos_k = k;
                        }
                        
                        Console.WriteLine($"{req_3[k]} + {res_3[i]} > {matrix[i, k]}   d{i + 1}{k + 1} = {d}");
                    }
                }
            }

            if (!flag)
            {
                Console.WriteLine($"max = {max} ({matrix[pos_i, pos_k]})\nОпорный план не является оптимальным");
            }
            else
            {
                Console.WriteLine("Опорный план является оптимальным");
            }

            Console.WriteLine();

            Optimization(matrix_2, pos_i, pos_k);


            // Вывод результата

            tableX2.Rows = m;
            tableX2.Columns = n;
            for (int i = 0; i < m; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    tableX2[i, k] = $"{matrix[i, k]} {(matrix_2[i, k] == 0 ? "" : $"[{matrix_2[i, k]}]")}";

                    if (i == 0)
                        tableX2.GetReq(k).Text = req[k].ToString();
                }
                tableX2.GetRes(i).Text = res[i].ToString();
            }


        }

        private void Optimization(int[,] matrix_2, int pos_i, int pos_k)
        {
            int[,] ex = new int[m, n]; // Таблица с исключениями
                                       // 0 - не проверялась
                                       // 1 - проверено

            // Допустимо 3 сгиба

            // По X вперед
            //for (int k = pos_k; k < n; k++)
            //{
            //    if (matrix_2[pos_i, k] != 0)
            //    {
            //        Console.WriteLine($"Check(1, {pos_i}, {k})");
            //        Check(1, pos_i, k, matrix_2, ex);
            //    }
            //}

            // По X назад

            // По Y вверх

            // По Y вниз

            ex[pos_i, pos_k] = 2;
            Check(pos_i, pos_k, matrix_2, ex);
        }

        private void Check(int center_i, int center_k, int[,] matrix_2, int[,] ex)
        {
            for (int i = 0; i < m; i++)
                if (ex[i, center_k] == 2)
                {
                    Console.WriteLine($"От {center_i} {center_k} можно провести до центра");
                }

            for (int k = 0; k < n; k++)
                if (ex[center_i, k] == 2)
                {
                    Console.WriteLine($"От {center_i} {center_k} можно провести до центра");
                }

            // По X вперед
            if (center_k + 1 < n && ex[center_i, center_k + 1] == 0)
            {
                for (int k = center_k + 1; k < n; k++)
                {
                    if (matrix_2[center_i, k] != 0) // Точка имеет стоимость
                    {
                        Console.WriteLine($"По x вперед: Check({center_i}, {k}, matrix_2, ex); Центр {center_i} {center_k}");
                        ex[center_i, k] = 1;
                        Check(center_i, k, matrix_2, ex);
                    }
                }
            }

            // По X назад
            if (center_k - 1 >= 0 && ex[center_i, center_k - 1] == 0)
            {
                for (int k = center_k - 1; k >= 0; k--)
                {
                    if (matrix_2[center_i, k] != 0) // Точка имеет стоимость
                    {
                        Console.WriteLine($"По x назад: Check({center_i}, {k}, matrix_2, ex); Центр {center_i} {center_k}");
                        ex[center_i, k] = 1;
                        Check(center_i, k, matrix_2, ex);
                    }
                }
            }

            // По Y вниз
            if (center_i + 1 < m && ex[center_i + 1, center_k] == 0)
            {
                for (int i = center_i + 1; i < m; i++)
                {
                    if (matrix_2[i, center_k] != 0) // Точка имеет стоимость
                    {
                        Console.WriteLine($"По y вниз: Check({i}, {center_k}, matrix_2, ex); Центр {center_i} {center_k}");
                        ex[i, center_k] = 1;
                        Check(i, center_k, matrix_2, ex);
                    }
                }
            }

            // По Y вверх
            if (center_i - 1 >= 0 && ex[center_i - 1, center_k] == 0)
            {
                for (int i = center_i - 1; i >= 0; i--)
                {
                    if (matrix_2[i, center_k] != 0) // Точка имеет стоимость
                    {
                        Console.WriteLine($"По y вверх: Check({i}, {center_k}, matrix_2, ex); Центр {center_i} {center_k}");
                        ex[i, center_k] = 1;
                        Check(i, center_k, matrix_2, ex);
                    }
                }
            }


        }


        private void btnExample1_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[,]
            {
                { 12, 0, 6, 5 },
                { 1, 2, 58, 12 },
                { 45, 4, 27, 90 }
            };

            int[] res = new int[] { 64, 23, 57 };
            int[] req = new int[] { 39, 32, 54, 19 };

            m = res.Length;
            n = req.Length;

            for (int i = 0; i < m; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    tableX1[i, k] = matrix[i, k].ToString();

                    if (i == 0)
                        tableX1.GetReq(k).Text = req[k].ToString();
                }
                tableX1.GetRes(i).Text = res[i].ToString();
            }
        }


    }
}
