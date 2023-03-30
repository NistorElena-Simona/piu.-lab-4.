using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_laborator_4
{
    internal class Program
    {
        static void Main(string[] args)
            ///pentru fiecare string din acel vector il afisez si il prelucrez si ii dau un nume pentru ail utiliza mai usor
        {///am creat o lista de liste de siruri de caractere
            List<List<string>> list = new List<List<string>>(26);
            for (int i = 0; i < 26 ; i++)
            {///am initializat listele din lista
            list.Add( new List<string> ());

           
            }
            Console.WriteLine(list.Count);
            foreach ( string c in args )
            {///in lista in locatia din parantezele patrate adaug acel cuvant
                if (c.ToUpper()[0]>=65 && c.ToUpper()[0]<=90)
               list[c.ToUpper()[0]-65].Add(c);///am  facut c cu litera mare,selectez primul caracter de pe pozitia 0, fac difereanta dintre codul ascii si 65 si imi da pozitiadin lista principala
                Console.WriteLine(c);
            }
            foreach ( List<string> l in list  )
            {
                if (l.Count>0)
                foreach( string c in l )
                {
                    Console.Write(c+" ");
                }
                else
                { Console.Write("null"); }
                Console.WriteLine();
            }

            
       /// A in codul ASCII e 65
        Console.ReadLine();

        }
    }
}
