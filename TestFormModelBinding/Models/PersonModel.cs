using System.Collections.Generic;

namespace TestFormModelBinding.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool ShouldBeUpdate { get; set; }
    }

    public class BulkEditViewModel
    {
        public List<PersonModel> PersonModels { get; set; } = new List<PersonModel>();
    }
}