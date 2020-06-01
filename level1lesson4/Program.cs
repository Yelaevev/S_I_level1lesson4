using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static int[] SynchronizingTables(int N, int[] ids, int[] salary)
        {
     
            int[] mass1 = new int[ids.Length];
            int[] temptest = new int[ids.Length];
            /////////////////////////////////// INITIAL CONDITION CHECK
            if ((ids.Length != N)|| (salary.Length!=N))
            {
                Console.WriteLine("initial conditions is falls");
                int[] falls = { 0, 0, 0 };
                return falls;
            }
            if (ids.Length != salary.Length)
            {
                Console.WriteLine("initial conditions is falls");
                int[] falls = { 0, 0, 0 };
                return falls;
            }
            for (int i = 0; i < ids.Length; i++)
            {
                   if (ids[i] <0)
                    {
                        Console.WriteLine("initial conditions is falls");
                        int[] falls = { 0, 0, 0 };
                        return falls;
                    }
             }
            for (int i = 0; i < salary.Length; i++)
            {
                if (salary[i] < 0)
                {
                    Console.WriteLine("initial conditions is falls");
                    int[] falls = { 0, 0, 0 };
                    return falls;
                }
            }
            for (int i =0; i<ids.Length;i++)
            {
                for (int j = 0; j < ids.Length; j++)
                {
                    if ((i != j) && (ids[i] == ids[j]))
                    {
                        Console.WriteLine("initial conditions is falls");
                        int[] falls={ 0,0,0};
                        return falls;
                    }
                }
            }
            //////////////////////////////////////////////



            //for (int i = 0; i < mass1.Length; i++)
            //{
            //    Console.Write(ids[i] + " ");
            //}
            //Console.WriteLine("ids ");

            for (int i = 0; i < mass1.Length; i++)
            {
                mass1[i] = ids[i];
            }
            Array.Sort(mass1);


            //for (int i = 0; i < mass1.Length; i++)
            //{
            //    Console.Write(mass1[i] + " ");
            //}
            //Console.WriteLine("idssort");

            int[] temp = new int[ids.Length];
            //for (int i = 0; i < mass1.Length; i++)
            //{
            //    Console.Write(salary[i] + "\t ");
            //}
            //Console.WriteLine("init salary ");


            int[] sravsort = new int[salary.Length];
            int[] zpitog = new int[salary.Length];
            for (int i = 0; i < mass1.Length; i++)
            {
                sravsort[i] = salary[i];
            }

            Array.Sort(sravsort);

            for (int i = 0; i < mass1.Length; i++)
            {
                for (int j = 0; j < ids.Length; j++)
                {
                    if (mass1[i] == ids[j])
                    {
                        temp[i] = j;
                    }
                }

            }

            for (int i = 0; i < mass1.Length; i++)
            {
                //for (int j = 0; j < ind.Length; j++)
                //{
                zpitog[temp[i]] = sravsort[i];
                //}

            }
            //for (int i = 0; i < mass1.Length; i++)
            //{
            //    Console.Write(ids[i] + "\t ");
            //}

            //Console.WriteLine("ind ");

            //for (int i = 0; i < mass1.Length; i++)
            //{
            //    Console.Write(zpitog[i] + "\t ");
            //}

            //Console.WriteLine("zpitog");

            return zpitog;
        }

        //static void Main(string[] args)
        //{
        //    int[] ind = { 2, 11, 10, 5, 3, 1 };
        //    int[] srav = { 1, 1, 30, 110, 50, 100 };

        //    int[] otvet = SynchronizingTables(ind.Length, ind, srav);

        //    for (int i = 0; i < otvet.Length; i++)
        //    {
        //        Console.Write(otvet[i] + "\t ");
        //    }
        //    Console.WriteLine("otvet ");

        //    for (int i = 0; i < ind.Length; i++)
        //    {
        //        Console.Write(ind[i] + "\t ");
        //    }
        //    Console.WriteLine("index ");

        //    for (int i = 0; i < ind.Length; i++)
        //    {
        //        Console.Write(srav[i] + " ");
        //    }
        //    Console.WriteLine("zarplata ");

        //}

    }
}
