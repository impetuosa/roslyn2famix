using Fame;



    [FamePackage("FAMIX")]
    [FameDescription("ThrownException")]
    public class ThrownException : Exception
    {
        [FameProperty(Name = "definingMethod") Opposite = "thrownExceptions"]
        public Method definingMethod { get; set; }







    }
}