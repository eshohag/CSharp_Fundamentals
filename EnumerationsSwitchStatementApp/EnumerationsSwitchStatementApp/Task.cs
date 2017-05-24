namespace EnumerationsSwitchStatementApp
{
    class Task
    {
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public Status Status { get; set; }

    }

    enum Status
    {
        //default assign integer value to store in our database  
        NotYetStarted,            //value- 0        
        InProgress,               //value- 1
        OnHold,                   //value- 2
        Completed,                //value- 3 
        Deleted                   //value- 4

    }
}
