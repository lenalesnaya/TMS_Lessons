using Lessons.Lesson5Tasks.Clinic;

namespace Lessons.Lesson5Tasks
{
    internal static class Lesson5
    {
        public static void Task1_UsePhoneClass()
        {
            Console.WriteLine("\nTask 1.\n");

            var phone1 = new Phone(375336987685, "Xiaomi", 300.55);
            var phone2 = new Phone(375296907644, "Samsung", 320.02);
            var phone3 = new Phone(375251087672, "Nokia", 280.55);

            Console.WriteLine($"{phone1.model}, {phone1.weight} g, {phone1.GetNumber():+#####-###-##-##}");
            Console.WriteLine($"{phone2.model}, {phone2.weight} g, {phone2.GetNumber():+#####-###-##-##}");
            Console.WriteLine($"{phone3.model}, {phone3.weight} g, {phone3.GetNumber():+#####-###-##-##}");

            phone1.ReceiveCall("Ann");
            phone2.ReceiveCall("Kate");
            phone3.ReceiveCall("Jim");

            phone1.ReceiveCall("Jenny", 375295510212);
            phone2.ReceiveCall("Kate", 375259082121);
            phone3.ReceiveCall("Jim", 375295430980);

            Phone.SendMessage(375336882510, 375332880011, 375296086689, 375336899870, 375256855523);
        }

        public static void Task2_UseCreditCardClass()
        {
            Console.WriteLine("\nTask 2.\n");

            var creditCard1 = new CreditCard("0MK");
            var creditCard2 = new CreditCard("B0025MK693D7");
            var creditCard3 = new CreditCard("B1225MN001B2", 1000m);
            var creditCard4 = new CreditCard("Z9825BN201K0", 6000m);

            creditCard1.ShowInfo();
            creditCard2.ShowInfo();
            creditCard3.ShowInfo();
            creditCard4.ShowInfo();

            creditCard2.ReplenishBalance(1500.50m);
            creditCard3.ReplenishBalance(5000m);
            creditCard4.WithdrawSum(500.40m);
        }

        public static void Task3_UseATM()
        {
            Console.WriteLine("\nTask 3.\n");
            var amountOf100ToIssue = 0;
            var amountOf50ToIssue = 0;
            var amountOf20ToIssue = 0;
            var atm = new ATM(1, 2, 1);

            var result = atm.WithdrawMoney(210, out amountOf100ToIssue, out amountOf50ToIssue, out amountOf20ToIssue);
            if (result)
            {
                Console.WriteLine($"\n100: {amountOf100ToIssue}, 50: {amountOf50ToIssue}, 20: {amountOf20ToIssue}");
            }

            atm.AddMoney(2, 0, 0);

            result = atm.WithdrawMoney(210, out amountOf100ToIssue, out amountOf50ToIssue, out amountOf20ToIssue);
            if (result)
            {
                Console.WriteLine($"\n100: {amountOf100ToIssue}, 50: {amountOf50ToIssue}, 20: {amountOf20ToIssue}");
            }
        }

        public static void Task4_UseClinic()
        {
            Console.WriteLine("\nTask 4.\n");

            var patientVolodya = new Patient("Volodya");

            patientVolodya.Treat();
            patientVolodya.CreateTreatmentPlan(27, 1, 2, 27);
            patientVolodya.Treat();
            patientVolodya.CancelTreatmentPlan();
            patientVolodya.Treat();

            var gastritisTreatmentPlan = new TreatmentPlan(27, 1, 27);

            patientVolodya.SetTreatmentPlan(gastritisTreatmentPlan);
            patientVolodya.Treat();
        }
    }
}