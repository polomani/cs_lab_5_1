using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new tect_CodeFirstContext())
            {
                try
                {
                    try {
                        ctx.lecturers.Remove(ctx.lecturers.ToList<lecturer>().ElementAt(0)); 
                        ctx.SaveChanges();
                    }
                    catch (Exception ex) { 
                        Console.WriteLine(ex.Message);
                    }
                    var lecturerList = ctx.lecturers.ToList<lecturer>();     
                    //Perform create operation               
                    Console.WriteLine("Perform create operation");        
                    ctx.lecturers.Add(new lecturer() {
                        lc_id = "L_1",
                        lc_fname = "New lecturer" 
                    });                    
                    //Execute Insert, Update & Delete queries in the database              
                    ctx.SaveChanges();
                    var lects1 = ctx.lecturers.ToList<lecturer>(); 
                    Lecturers_print(lects1);
                    //Perform Update operation              
                    Console.WriteLine("Perform Update operation");        
                    var lecturerList1 = ctx.lecturers.ToList<lecturer>();     
                    lecturer lecturerToUpdate = lecturerList1.Where(s => s.lc_fname == "New lecturer").FirstOrDefault<lecturer>();      
                    lecturerToUpdate.lc_fname = "Edited lecturer";    
                    //Execute Insert, Update & Delete queries in the database     
                    ctx.SaveChanges();
                    lects1 = ctx.lecturers.ToList<lecturer>(); 
                    Lecturers_print(lects1);


                    Console.WriteLine(); 
                    SQL_qry(ctx); 
                    Console.WriteLine();

                    Console.WriteLine("Transaction example");
                    Transaction_test tr = new Transaction_test(); 
                    tr.StartOwnTransactionWithinContext();

                    lects1 = ctx.lecturers.ToList<lecturer>(); Lecturers_print(lects1);           
                    //Perform delete operation, re-read lecturers list                 
                    Console.WriteLine("Perform delete operation");           
                    lecturerList1 = ctx.lecturers.ToList<lecturer>();                
                    ctx.lecturers.Remove(lecturerList1.ElementAt<lecturer>(0));       
                    ctx.lecturers.Remove(lecturerList1.Where(s => s.lc_fname == "Edited second lecturer").FirstOrDefault<lecturer>());
                    //Execute Insert, Update & Delete queries in the database           
                    ctx.SaveChanges();
                    lects1 = ctx.lecturers.ToList<lecturer>(); Lecturers_print(lects1);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                Console.ReadKey();
            }
        }

        static void Lecturers_print(List<lecturer> mylist) {
            Console.WriteLine("Lecturers list:"); 
            foreach (lecturer u in mylist)
            { 
                Console.WriteLine("{0}.{1} ", u.lc_id, u.lc_fname); 
            } 
        }

        static void SQL_qry(tect_CodeFirstContext ctx) { 
            Console.WriteLine("Native SQL query. Find key "); 
            var lect1 = ctx.lecturers.SqlQuery("select * from lecturers where lc_id = 'L_1';");
            Console.WriteLine(lect1.ElementAt(0).lc_id); 
        } 
    }
}
