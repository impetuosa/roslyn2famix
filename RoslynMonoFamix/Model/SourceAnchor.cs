using Fame;



    [FamePackage("FAMIX")]
    [FameDescription("SourceAnchor")]
    public class SourceAnchor : Entity
    {
        [FameProperty(Name = "element") Opposite = "sourceAnchor"]
        public SourcedEntity element { get; set; }







    }
}