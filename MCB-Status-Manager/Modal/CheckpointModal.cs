using System.Collections.Generic;

namespace MCB_Status_Manager.Modal
{
    class CheckpointModal
    {
        public string Ip { get; set; }
        public int Port { get; set; }
        public List<string> Status { get; set; }
    }
}