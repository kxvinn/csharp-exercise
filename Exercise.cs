using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_class_sript
{
    class Exercise
    {
        // crie um sistema para receber o nome e ano de nascimento de uma pessoa. ao final, deverá ser exibido, aproximadamente,
        // os seguintes dados:
        // - idade ; quantidade de dias vividos ; qtd. de horas vividas ; qtd. de minutos vividos ; qtd. de batimentos cardiacos.

        // qtd. media de batimentos cardiacos de uma pessoa é 75 por minuto.

        static void Main(string[] args)
        {

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Which year did you born? Use YYYY-MM-DD");
            string birth = Console.ReadLine();

            if (DateTime.TryParse(birth, out DateTime birthdate))

            {
                DateTime currentdate = DateTime.Now;


                TimeSpan agespan = currentdate - birthdate;

                int daysLived = (int)agespan.TotalDays;

                int hoursLived = (int)agespan.TotalHours;

                int minutesLived = (int)agespan.TotalMinutes;

                int heartBeats = minutesLived * 75;

                bool continueRunning = true;
                while (continueRunning)
                {

                    Console.WriteLine($"\n\n{name}, Please choose an Option from 1 to 4: \n\n" +
                     "1: Your Days lived; \n" +
                     "2: Your Hours lived; \n" +
                     "3: Your Minutes lived; \n" +
                     "4: the amount of beats of your heart until now;\n" +
                     "5: Exit \n");





                    int options;

                    if (int.TryParse(Console.ReadLine(), out options))

                        switch (options)
                        {
                            case 1:

                                Console.WriteLine($"\n\nYou lived {daysLived} days.\n");
                                break;

                            case 2:

                                Console.WriteLine($"\n\nYou lived {hoursLived} hours.\n");
                                break;

                            case 3:

                                Console.WriteLine($"\n\nYou lived {minutesLived} minutes. \n");
                                break;

                            case 4:

                                Console.WriteLine($"\n\nYour heart beat {heartBeats} times until now. \n");
                                break;

                            case 5:
                                Console.WriteLine("\n\nExiting the program... Bye!\n");
                                continueRunning = false;
                                break;


                            default:
                                Console.WriteLine("Please input a number from 1 to 4.");
                                break;


                        }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }

                }
            }
             else
            {
                Console.WriteLine("Invalid date format. Please enter the date in YYYY-MM-DD format.");
            }
            }
        }
    }


        

        
    

