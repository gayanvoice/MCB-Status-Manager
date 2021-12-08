namespace MCB_Status_Manager.Modal
{
    class IpAddressModal
    {
        public string IpAddress { get; set; }
        public string Tag { get; set; }
        public HostModal[] Host { get; set; }
        public EmailModal[] Email { get; set; }
    }
}