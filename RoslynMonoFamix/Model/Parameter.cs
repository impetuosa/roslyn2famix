using Fame;



    [FamePackage("FAMIX")]
    [FameDescription("Parameter")]
    public class Parameter : StructuralEntity
    {
        [FameProperty(Name = "parentBehaviouralEntity") Opposite = "parameters"]
        public BehaviouralEntity parentBehaviouralEntity { get; set; }







    }
}