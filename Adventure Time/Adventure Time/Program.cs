using System;

namespace Adventure_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sup Fool You Wanna Play A Game?");
            string answer = Console.ReadLine();
            answer.ToLower();
            if (answer == "yes")
            {
                Console.WriteLine("Aight fool lets go!");
            }
            else if (answer == "no")
            {
                Console.WriteLine("*Smacks the Taste out ya mouth*");
            }
            else
            {
                Console.WriteLine("Game Over");
            } Second();
        }
        public static void Second()
        {
            string Choice;

            Console.WriteLine("you spawn in on the southside of chicago you're infront of  a corner store a crackhead approaches ");
            Console.WriteLine("the crackhead ask hey can I get some change man Im trying to get high ");
            Console.WriteLine("what do you do? ");
            Console.WriteLine("1.give the crackhead five dollars ");
            Console.WriteLine("2.Beat up the crackhead for using crack ");
            Console.WriteLine("3.tell the crackhead you don't have any money ");
            Console.Write("Choice: ");
            Choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (Choice)
            {
                case "1":
                    {
                        Console.WriteLine("you give the crackhead five dollars ");
                        Console.WriteLine("the crackhead looks at you an smiles  ");
                        Console.WriteLine("and begins to sing Old town Road by lil Nas X ");
                        Console.WriteLine("the crackhead begins to hit the stanky leg ");
                        Console.WriteLine("moonwalks and flys away never to be seen or heard from again ");
                        Console.ReadLine();
                        Third();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You wind up and strike the crackhead in the face he falls over in pain");
                        Console.WriteLine("you then you start stomping the kicking the crackhead ");
                        Console.WriteLine("you pick the crackhead up and proceed to put him in an ankle lock");
                        Console.WriteLine("the crackhead cries in pain begging for you to stop ");
                        Console.WriteLine("so you offer to stop only if the crackhead promises to give up crack");
                        Console.WriteLine("the crackhead looks you in the eye and tells you just break it in which you proceed to do so");
                        Console.WriteLine("so much for that you can make a crackhead quit smoking crack");
                        Console.ReadLine();
                        Third();
                        break;
                    }

                case "3":
                    {
                        Console.WriteLine("You don't have any money! the crackhead screams");
                        Console.WriteLine("The crackhead continues 'what are you doing with ya life'");
                        Console.WriteLine("the crackhead to reaches into his pocket and pulls out some crack");
                        Console.WriteLine("he approaches you hand extended and drops the crack in your hand ");
                        Console.WriteLine("you need this more than me the crackheads says and swiftly walks away");
                        Console.WriteLine("At this moment you threw you life away and began smoking crack GAME OVER!");
                        Console.ReadLine();
                        break;

                    }

            }
        }

        public static void Third()
        {
            string Option;

            Console.WriteLine("As you continue on your way you come across five gang members that resemble chief keef your heart starts to race ");
            Console.WriteLine("if you continue this route you will collide with them head on what do you do so you decide to cross to the otherside ");
            Console.WriteLine("as you cross one of the gang members shouts AYE CHECK IT OUT! you look freeze where you stand what do you do?");
            Console.WriteLine("A.Go check it out");
            Console.WriteLine("B.run for your life ");
            Console.WriteLine("C.act like your having a nervous breakdown begin stripping off close");
            Console.Write("Option: ");
            Option = Console.ReadLine().ToLower();
            Console.Clear();

            switch (Option) {

                case "A":
                    {
                        Console.WriteLine("You walk over to the gang members to see what they ");
                        Console.WriteLine("one of the gang members ask do whats a database?");
                        Console.WriteLine("You respond a database is like a box- you are instantly struck mid sentence with a bat");
                        Console.WriteLine("the gang members beat and robbed Game Over!");
                        Console.ReadLine();
                        break;
                    }


                case "B":

                    {

                        Console.WriteLine("You take a quick glance to see where the gang members are and you take off");
                        Console.WriteLine("your running like your life depends on it you want to look back ");
                        Console.WriteLine("but your too scared so you run faster cutting through gangways in and out of traffic");
                        Console.WriteLine("your lungs are on fire but your fear keeps you running ");
                        Console.WriteLine("eventually after awhile you slow down you pretty sure you lost them ");
                        Console.WriteLine("begin to look for a bus to take you home");
                        Console.ReadLine();
                        break;




                    }

                case "C":
                    {
                        Console.WriteLine("As a means of survival you begin to scream an yell nonesense and twitch uncontrollably");
                        Console.WriteLine("it gang members stare and look in confusion");
                        Console.WriteLine("you begin to strip off you clothing and dance hoping to scare the gang members away");
                        Console.WriteLine("it works the gang members runaway in terror");
                       Console.WriteLine("but maybe to well because the crackheads in the area see you and start to join in");
                        Console.WriteLine("run for shelter and to avoid the mob of naked crackheads");
                        Console.ReadLine();
                        break;

                    }
            }
        }

                public static void YouSurvived()
                {
                    Console.WriteLine("you spawn in on the southside of chicago you infront of corner store a crackhead approches ");
                    Console.WriteLine("the crackhead ask hey can I get some change man Im trying to get high ");
                }
            
        
    

    

    

