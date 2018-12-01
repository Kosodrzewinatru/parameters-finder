using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parametersFinder
{
    class Inside
    {
        public Member[] population;
        private int n;
        private Member secondParent = null;
        private Member firstParent;

        internal Member FirstParent { get => firstParent; }

        public Inside(int n)
        {
            this.n = n;
            population = new Member[n];
            Random rnd = new Random();
            for (int i = 0; i < population.Length; i++)
            {
                Member temp = new Member();
                temp.a = rnd.NextDouble();
                int chance = rnd.Next(0, 2);
                if (chance == 1)
                    temp.a *= -1;

                temp.b = rnd.NextDouble();
                chance = rnd.Next(0, 2);
                if (chance == 1)
                    temp.b *= -1;

                temp.c = rnd.NextDouble();
                chance = rnd.Next(0, 2);
                if (chance == 1)
                    temp.c *= -1;

                population[i] = temp;
            }

        }

        public void CalcFitness(double x1, double x2)
        {
            for (int i = 0; i < population.Length; i++)
            {
                double a = population[i].a;
                double b = population[i].b;
                double c = population[i].c;

                population[i].fitness = (Math.Abs(Math.Pow(x1, 2) * a + b * x1 + c) + Math.Abs(Math.Pow(x2, 2) * a + b * x2 + c)) * -1; 
            }
        }

        public void FindParents()
        {
            double fp = population[0].fitness, sp = population[0].fitness;
            for (int i = 0; i < population.Length; i++)
            {
                if (population[i].fitness > fp)
                {
                    fp = population[i].fitness;
                    firstParent = population[i];
                }
            }

            for (int i = 0; i < population.Length; i++)
            {
                if (population[i] != firstParent)
                {
                    if (population[i].fitness > sp)
                    {
                        sp = population[i].fitness;
                        secondParent = population[i];
                    }
                }
            }
        }

        public void NextGen(double m)
        {
            Random rnd = new Random();
            for (int i = 0; i < population.Length; i++)
            {
                population[i].a = rnd.NextDouble() > 0.5 ? firstParent.a : secondParent.a;
                population[i].b = rnd.NextDouble() > 0.5 ? firstParent.b : secondParent.b;
                population[i].c = rnd.NextDouble() > 0.5 ? firstParent.c : secondParent.c;

                if (rnd.NextDouble() <= m)
                    population[i].a += (rnd.NextDouble() * 0.6 - 0.3);
                if (rnd.NextDouble() <= m)
                    population[i].b += (rnd.NextDouble() * 0.6 - 0.3);
                if (rnd.NextDouble() <= m)
                    population[i].c += (rnd.NextDouble() * 0.6 - 0.3);
            }
        }
    }
}
