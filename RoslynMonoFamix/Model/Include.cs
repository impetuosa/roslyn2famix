using Fame;



    [FamePackage("FAMIX")]
    [FameDescription("Include")]
    public class Include : Association
    {
        [FameProperty(Name = "target") Opposite = "incomingIncludeRelations"]
        public CFile target { get; set; }

        [FameProperty(Name = "source") Opposite = "outgoingIncludeRelations"]
        public CFile source { get; set; }







    }
}