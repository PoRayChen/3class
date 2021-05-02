using System;

namespace _3class
{
    public class Melody
    {
        static void Main(string[] agrs)
        {
            var Dream1 = new Dream("Dream #1");
            var Dream2 = new Dream("Dream #2");
            var Dream3 = new Dream("Dream #3");
            var Dream4 = new Dream("Dream #4");
            var DreamsParty = new Party<Dream>(Dream1);
            DreamsParty.AddMember(Dream2);
            DreamsParty.AddMember(Dream3);
            DreamsParty.AddMember(Dream4);
            DreamsParty.RemoveMember(Dream3); 
            Console.ReadLine();

            var Tommy1 = new Tommy("Tommy #1");
            var Tommy2 = new Tommy("Tommy #2");
            var Tommy3 = new Tommy("Tommy #3");
            var Tommy4 = new Tommy("Tommy #4");
            var TommysParty = new Party<Tommy>(Tommy1);
            TommysParty.AddMember(Tommy2);
            TommysParty.AddMember(Tommy3);
            TommysParty.AddMember(Tommy4);
            TommysParty.RemoveMember(Tommy3);
            Console.ReadLine();

            var Technoblade1 = new Technoblade("Technoblade #1");
            var Technoblade2 = new Technoblade("Technoblade #2");
            var Technoblade3 = new Technoblade("Technoblade #3");
            var Technoblade4 = new Technoblade("Technoblade #4");
            var TechnobladesParty = new Party<Technoblade>(Technoblade1);
            TechnobladesParty.AddMember(Technoblade2);
            TechnobladesParty.AddMember(Technoblade3);
            TechnobladesParty.AddMember(Technoblade4);
            TechnobladesParty.RemoveMember(Technoblade3);
            Console.ReadLine();
        }
    }
}
