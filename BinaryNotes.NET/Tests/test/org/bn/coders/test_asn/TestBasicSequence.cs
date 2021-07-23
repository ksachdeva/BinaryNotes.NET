
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
    [ASN1Sequence ( Name = "TestBasicSequence", IsSet = false  )]
    public class TestBasicSequence : IASN1PreparedElement {
                    
	private long simple_integer_ ;
	[ASN1Integer( Name = "" )]
    
        [ASN1Element ( Name = "simple-integer", IsOptional =  false , HasTag =  false  , HasDefaultValue =  false )  ]
    
        public long Simple_integer
        {
            get { return simple_integer_; }
            set { simple_integer_ = value;  }
        }
        
                
          
	private byte[] simple_octet_string_ ;
	[ASN1OctetString( Name = "" )]
    
        [ASN1Element ( Name = "simple-octet-string", IsOptional =  false , HasTag =  false  , HasDefaultValue =  false )  ]
    
        public byte[] Simple_octet_string
        {
            get { return simple_octet_string_; }
            set { simple_octet_string_ = value;  }
        }
        
                
  

            public void initWithDefaults() {
            	
            }


            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(TestBasicSequence));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

            
    }
            
}
