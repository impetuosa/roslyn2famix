using Fame;



    [FamePackage("FAMIX")]
    [FameDescription("StructuralEntity")]
    public class StructuralEntity : LeafEntity
    {
        [FameProperty(Name = "declaredType") Opposite = "structuresWithDeclaredType"]
        public Type declaredType { get; set; }









    }
}