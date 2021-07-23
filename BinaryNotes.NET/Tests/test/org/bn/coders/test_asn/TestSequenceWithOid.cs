
//
// This file was generated by the BinaryNotes compiler.
// See http://bnotes.sourceforge.net 
// Any modifications to this file will be lost upon recompilation of the source ASN.1. 
//

using System;
using org.bn.attributes;
using org.bn.attributes.constraints;
using org.bn.coders;
using org.bn.types;
using org.bn;

namespace test.org.bn.coders.test_asn {


    [ASN1PreparedElement]
    [ASN1Sequence ( Name = "TestSequenceWithOid", IsSet = false  )]
    public class TestSequenceWithOid : IASN1PreparedElement {
                    
	private ObjectIdentifier simple_oid_ ;
	[ASN1ObjectIdentifier( Name = "" )]
    
        [ASN1Element ( Name = "simple-oid", IsOptional =  false , HasTag =  false  , HasDefaultValue =  false )  ]
    
        public ObjectIdentifier Simple_oid
        {
            get { return simple_oid_; }
            set { simple_oid_ = value;  }
        }
        
                
          
	private long simple_integer_ ;
	[ASN1Integer( Name = "" )]
    
        [ASN1Element ( Name = "simple-integer", IsOptional =  false , HasTag =  false  , HasDefaultValue =  false )  ]
    
        public long Simple_integer
        {
            get { return simple_integer_; }
            set { simple_integer_ = value;  }
        }
        
                
  

            public void initWithDefaults() {
            	
            }


            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(TestSequenceWithOid));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

            
    }
            
}
