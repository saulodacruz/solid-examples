namespace SOLID.O
{
    public abstract class GenerateReport
    {
        public void GenerateFull()
        {
            // Common logic for complete report
        }

        public abstract void GenerateResume();
    }

    public class GenerateDeliveriesReport : GenerateReport
    {
        public override void GenerateResume()
        {
            // Generate deliveries relatory resume
        }
    }
}
