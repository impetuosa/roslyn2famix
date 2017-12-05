using Fame;



    [FamePackage("FAMIX")]
    [FameDescription("Invocation")]
    public class Invocation : Association
    {
        [FameProperty(Name = "sender") Opposite = "outgoingInvocations"]
        public BehaviouralEntity sender { get; set; }

        [FameProperty(Name = "receiver") Opposite = "receivingInvocations"]
        public NamedEntity receiver { get; set; }


        [FameProperty(Name = "signature")]
        public String signature { get; set; }







    }
}