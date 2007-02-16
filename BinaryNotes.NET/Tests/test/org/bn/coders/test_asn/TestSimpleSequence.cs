
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
    [ASN1Sequence ( Name = "TestSimpleSequence", IsSet = false  )]
    public class TestSimpleSequence : IASN1PreparedElement {
                    
	private long field1_ ;
	[ASN1Integer( Name = "" )]
    
        [ASN1Element ( Name = "field1", IsOptional =  false , HasTag =  true, Tag = 0 , HasDefaultValue =  false )  ]
    
        public long Field1
        {
            get { return field1_; }
            set { field1_ = value;  }
        }
        
                
          
	private string field2_ ;
	[ASN1String( Name = "", 
        StringType =  UniversalTags.UTF8String , IsUCS = false )]
        [ASN1Element ( Name = "field2", IsOptional =  false , HasTag =  true, Tag = 1 , HasDefaultValue =  false )  ]
    
        public string Field2
        {
            get { return field2_; }
            set { field2_ = value;  }
        }
        
                
          
	private string field3_ ;
	[ASN1String( Name = "", 
        StringType =  UniversalTags.UTF8String , IsUCS = false )]
        [ASN1Element ( Name = "field3", IsOptional =  false , HasTag =  true, Tag = 2 , HasDefaultValue =  false )  ]
    
        public string Field3
        {
            get { return field3_; }
            set { field3_ = value;  }
        }
        
                
  

            public void initWithDefaults() {
            	
            }


            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(TestSimpleSequence));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

            
    }
            
}
