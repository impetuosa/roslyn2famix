using Fame;



    [FamePackage("FAMIX")]
    [FameDescription("DereferencedInvocation")]
    public class DereferencedInvocation : Invocation
    {
        [FameProperty(Name = "referencer") Opposite = "dereferencedInvocations"]
        public StructuralEntity referencer { get; set; }







    }
}