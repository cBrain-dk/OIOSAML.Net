using System;
using System.Xml.Serialization;

namespace dk.nita.saml20.Schema.Metadata
{
  /// <summary>
  /// The &lt;ApplicationServiceType&gt; element extends RoleDescriptorType.
  /// </summary>

  [Serializable]
  [XmlType(Namespace = Saml20Constants.FEDERATION, TypeName = nameof(ApplicationServiceType))]
  [XmlRoot(ELEMENT_NAME, Namespace = Saml20Constants.METADATA, IsNullable = false)]
  public class ApplicationServiceType : RoleDescriptor
  {
    /// <summary>
    /// .
    /// </summary>
    public ApplicationServiceType()
    {
    }
  }
}
