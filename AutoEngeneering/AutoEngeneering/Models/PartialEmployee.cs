using System;

namespace AutoEngeneering.Models
{
    public partial class employee
    {
        public String Initials => $"{lastName} {firstName[0]}. {middleName[0]}.";
        public String FullName => $"{lastName} {firstName} {middleName}";

        public override String ToString() => FullName;
    }
}
