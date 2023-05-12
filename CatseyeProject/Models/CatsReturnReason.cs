namespace CatseyeProject.Models
{
    public class CatsReturnReason:BaseClass
    {
        public string Reason { get; set; }
        public float FlatDamageFee { get; set; }
        public float PerDamageFee { get; set; }
        public bool RefundShippingFeee { get; set; }
    }
}
