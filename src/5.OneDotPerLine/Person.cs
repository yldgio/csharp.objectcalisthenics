using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.OneDotPerLine;

public class Person
{
    public Address HomeAddress { get; set; }

}
public class Address
{
    public string Line1 { get; set; }
    public string Line2 { get; set; }
    public string PostCode { get; set; }
}
public class Pet
{
    public string Name { get; set; }
    public Person Owner { get; set; }
    public void SetPostCode(string code) { 
        Owner.HomeAddress.PostCode = code;
    }
}