namespace VersionAttribute
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface |
                    AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = true)]

    public class VersionAttribute : Attribute
    {
        public VersionAttribute(string name, string version)
        {
            this.Name = name;
            this.Version = version;
        }

        public string Name { get; private set; }
        public string Version { get; private set; }
    }
}
