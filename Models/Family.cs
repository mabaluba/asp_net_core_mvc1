using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace asp_net_core_mvc1.Models
{
    public class Family
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Как величать!")]//если не прописывать во вьюшке название лейбла, то можно использовать атрибут в модели
        public string Name { get; set; }
        public byte Age { get; set; }
        public string Gender { get; set; }

    }
}
