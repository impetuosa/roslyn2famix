using Fame;
using System;
using FILE;
using Dynamix;
using FAMIX;
using System.Collections.Generic;

namespace FAMIX
{
  [FamePackage("FAMIX")]
  [FameDescription("Include")]
  public class Include : FAMIX.Association
  {
    [FameProperty(Name = "target",  Opposite = "incomingIncludeRelations")]    
    public FAMIX.CFile target { get; set; }
    
    [FameProperty(Name = "source",  Opposite = "outgoingIncludeRelations")]    
    public FAMIX.CFile source { get; set; }
    
  }
}
