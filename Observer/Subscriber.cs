using Design_Patterns_Assignment.Observer.Interfaces;
using System;

namespace Design_Patterns_Assignment.Observer
{
    internal class Subscriber : ISubscriber
    {
        public void Update()
        {
            string email = "This is Brenda J. Gonzalez (LTC) of the U.S Army Special Operations Command (USASOC), 7th Special Forces Group (Airborne), Air Force Base – Afghanistan. \n Please I need your urgent assistance in securing a consignment(two trunk boxes) containing($20,000,000), the funds are surpluses of several contracts executed by my department during a supply of MH(Military Hardware). \n\n If you receive this message please e-mail me immediately with a delivery address and your full contact information; the deal is 60/40 split (60% for me and 40% for you); \n I am not a greedy woman and I hope you will not double cross a struggling uniform single mother with 3 teenage children? Once you receive the consignment($20,000,000) take out your 40% ($8,000,000) and save my 60% ($12,000,000) for me until I return back to the U.S mid-next year after my deployment.";
            
            Console.WriteLine(email);
        }
    }
}