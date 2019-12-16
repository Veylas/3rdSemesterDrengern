using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace ClientToService.ModelLayer
{
    [DataContract]
    public class Auction : IAuction
    { 
    [DataMember]
        
        public int Id { get; set; }
    [DataMember]
        
        public DateTime EndDate { get; set; }
    [DataMember]
    public int Time { get; set; }
        
        [DataMember]
    public int Status { get; set; }
    
        [DataMember]
    public decimal CurrentPrice { get; set; }
      
        [DataMember]
    public decimal MaxPrice { get; set; }
      
        [DataMember]
    public decimal Bid { get; set; }
      
        [DataMember]
    public string CurrentWinner { get; set; }
        
        [DataMember]
    public string Title { get; set; }
      
        [DataMember]
    public string Description { get; set; }
     
        [DataMember]
    public string Category { get; set; }
     }
}
