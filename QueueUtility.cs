    class QueueUtility
    {
        Node front, rear;
        Bank bank = new Bank();
        public void AddMoneyRecords(Bank newNode)
        {
            this.bank.balance = newNode.balance;
        }
        public void ShowCustomerStatus(Node newNode)
        {
            QueueUtility utility = new QueueUtility();
            Console.WriteLine("Customer Name=" +newNode.Name+
                "\n Customer Balance="+newNode.balance);
            validTwo:
            Console.WriteLine("1.Deposite \n2.Withdrawal \n" +"3.exit\n"+
               "4.Bank Status \nenter your option.");
            int option = Convert.ToInt32(Console.ReadLine());
		switch (option)
            {
                case 1:
                    Console.WriteLine("enter amount to deposite:");
                    int deposite = Convert.ToInt32(Console.ReadLine());
                    newNode.balance += deposite;
                    bank.balance += newNode.balance;
                    utility.AddMoneyRecords(bank);
                    utility.ShowCustomerStatus(newNode);
                    break;

                case 2:
                    Console.WriteLine("enter amount to withdrawal:");
                    int withdrawal = Convert.ToInt32(Console.ReadLine());
                    newNode.balance -= withdrawal;
                    bank.balance -= newNode.balance;
                    utility.AddMoneyRecords(bank); 
                    utility.ShowCustomerStatus(newNode);
                    break;

                case 3:
                    utility.Dequeue();
                    Console.WriteLine("customer is out of the queue.");
                    break;

                case 4: Console.WriteLine("Bank Balance="+this.bank.balance);
                    goto validTwo;

                default:
                    Console.WriteLine("invalid input!! enter your option again:");
                    goto validTwo;
            }
        }
        public void EnQueue(string Name,int balance)
        {
            this.bank.balance = 10000000;
            QueueUtility utility = new QueueUtility();
            Node newNode = new Node(Name);
            newNode.balance = balance;
            //bank.balance += newNode.balance;
            //utility.AddMoneyRecords(bank);
            if (rear == null)
            {
                front = rear = newNode;
            }
            rear.next = newNode;
            rear = newNode;
            Console.WriteLine("1.Deposite \n2.Withdrawal \n" +
                "enter your option.");
            validOne:
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1: Console.WriteLine("enter amount to deposite:");
                        int deposite = Convert.ToInt32(Console.ReadLine());
                    newNode.balance += deposite;
                    bank.balance += newNode.balance;
                    utility.AddMoneyRecords(bank); 
                    utility.ShowCustomerStatus(newNode);
                    break;

                case 2:
                    Console.WriteLine("enter amount to withdrawal:");
                    int withdrawal = Convert.ToInt32(Console.ReadLine());
                    newNode.balance -= withdrawal;
                    bank.balance -= newNode.balance;
                    utility.AddMoneyRecords(bank);
                    utility.ShowCustomerStatus(newNode);
                    break;
                default:
                    Console.WriteLine("invalid input!! enter your option again:");
                    goto validOne;
            }
        }
