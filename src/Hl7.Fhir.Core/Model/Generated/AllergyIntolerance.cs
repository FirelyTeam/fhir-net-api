﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;
using System.ComponentModel;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

//
// Generated for FHIR v1.8.0
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Allergy or Intolerance (generally: Risk of adverse reaction to a substance)
    /// </summary>
    [FhirType("AllergyIntolerance", IsResource=true)]
    [DataContract]
    public partial class AllergyIntolerance : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.AllergyIntolerance; } }
        [NotMapped]
        public override string TypeName { get { return "AllergyIntolerance"; } }
        
        /// <summary>
        /// The clinical status of the allergy or intolerance.
        /// (url: http://hl7.org/fhir/ValueSet/allergy-clinical-status)
        /// </summary>
        [FhirEnumeration("AllergyIntoleranceClinicalStatus")]
        public enum AllergyIntoleranceClinicalStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-clinical-status)
            /// </summary>
            [EnumLiteral("active"), Description("Active")]
            Active,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-clinical-status)
            /// </summary>
            [EnumLiteral("inactive"), Description("Inactive")]
            Inactive,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-clinical-status)
            /// </summary>
            [EnumLiteral("resolved"), Description("Resolved")]
            Resolved,
        }

        /// <summary>
        /// Assertion about certainty associated with a propensity, or potential risk, of a reaction to the identified substance.
        /// (url: http://hl7.org/fhir/ValueSet/allergy-verification-status)
        /// </summary>
        [FhirEnumeration("AllergyIntoleranceVerificationStatus")]
        public enum AllergyIntoleranceVerificationStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-verification-status)
            /// </summary>
            [EnumLiteral("unconfirmed"), Description("Unconfirmed")]
            Unconfirmed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-verification-status)
            /// </summary>
            [EnumLiteral("confirmed"), Description("Confirmed")]
            Confirmed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-verification-status)
            /// </summary>
            [EnumLiteral("refuted"), Description("Refuted")]
            Refuted,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-verification-status)
            /// </summary>
            [EnumLiteral("entered-in-error"), Description("Entered In Error")]
            EnteredInError,
        }

        /// <summary>
        /// Identification of the underlying physiological mechanism for a Reaction Risk.
        /// (url: http://hl7.org/fhir/ValueSet/allergy-intolerance-type)
        /// </summary>
        [FhirEnumeration("AllergyIntoleranceType")]
        public enum AllergyIntoleranceType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-intolerance-type)
            /// </summary>
            [EnumLiteral("allergy"), Description("Allergy")]
            Allergy,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-intolerance-type)
            /// </summary>
            [EnumLiteral("intolerance"), Description("Intolerance")]
            Intolerance,
        }

        /// <summary>
        /// Category of an identified substance.
        /// (url: http://hl7.org/fhir/ValueSet/allergy-intolerance-category)
        /// </summary>
        [FhirEnumeration("AllergyIntoleranceCategory")]
        public enum AllergyIntoleranceCategory
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-intolerance-category)
            /// </summary>
            [EnumLiteral("food"), Description("Food")]
            Food,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-intolerance-category)
            /// </summary>
            [EnumLiteral("medication"), Description("Medication")]
            Medication,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-intolerance-category)
            /// </summary>
            [EnumLiteral("biologic"), Description("Biologic")]
            Biologic,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-intolerance-category)
            /// </summary>
            [EnumLiteral("environment"), Description("Environment")]
            Environment,
        }

        /// <summary>
        /// Estimate of the potential clinical harm, or seriousness, of a reaction to an identified substance.
        /// (url: http://hl7.org/fhir/ValueSet/allergy-intolerance-criticality)
        /// </summary>
        [FhirEnumeration("AllergyIntoleranceCriticality")]
        public enum AllergyIntoleranceCriticality
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-intolerance-criticality)
            /// </summary>
            [EnumLiteral("low"), Description("Low Risk")]
            Low,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-intolerance-criticality)
            /// </summary>
            [EnumLiteral("high"), Description("High Risk")]
            High,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-intolerance-criticality)
            /// </summary>
            [EnumLiteral("unable-to-assess"), Description("Unable to Assess Risk")]
            UnableToAssess,
        }

        /// <summary>
        /// Statement about the degree of clinical certainty that a specific substance was the cause of the manifestation in an reaction event.
        /// (url: http://hl7.org/fhir/ValueSet/reaction-event-certainty)
        /// </summary>
        [FhirEnumeration("AllergyIntoleranceCertainty")]
        public enum AllergyIntoleranceCertainty
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/reaction-event-certainty)
            /// </summary>
            [EnumLiteral("unlikely"), Description("Unlikely")]
            Unlikely,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/reaction-event-certainty)
            /// </summary>
            [EnumLiteral("likely"), Description("Likely")]
            Likely,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/reaction-event-certainty)
            /// </summary>
            [EnumLiteral("confirmed"), Description("Confirmed")]
            Confirmed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/reaction-event-certainty)
            /// </summary>
            [EnumLiteral("unknown"), Description("Unknown")]
            Unknown,
        }

        /// <summary>
        /// Clinical assessment of the severity of a reaction event as a whole, potentially considering multiple different manifestations.
        /// (url: http://hl7.org/fhir/ValueSet/reaction-event-severity)
        /// </summary>
        [FhirEnumeration("AllergyIntoleranceSeverity")]
        public enum AllergyIntoleranceSeverity
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/reaction-event-severity)
            /// </summary>
            [EnumLiteral("mild"), Description("Mild")]
            Mild,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/reaction-event-severity)
            /// </summary>
            [EnumLiteral("moderate"), Description("Moderate")]
            Moderate,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/reaction-event-severity)
            /// </summary>
            [EnumLiteral("severe"), Description("Severe")]
            Severe,
        }

        [FhirType("ReactionComponent")]
        [DataContract]
        public partial class ReactionComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ReactionComponent"; } }
            
            /// <summary>
            /// Specific substance or pharmaceutical product considered to be responsible for event
            /// </summary>
            [FhirElement("substance", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Substance
            {
                get { return _Substance; }
                set { _Substance = value; OnPropertyChanged("Substance"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Substance;
            
            /// <summary>
            /// unlikely | likely | confirmed | unknown
            /// </summary>
            [FhirElement("certainty", Order=50)]
            [DataMember]
            public Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceCertainty> CertaintyElement
            {
                get { return _CertaintyElement; }
                set { _CertaintyElement = value; OnPropertyChanged("CertaintyElement"); }
            }
            
            private Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceCertainty> _CertaintyElement;
            
            /// <summary>
            /// unlikely | likely | confirmed | unknown
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceCertainty? Certainty
            {
                get { return CertaintyElement != null ? CertaintyElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        CertaintyElement = null; 
                    else
                        CertaintyElement = new Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceCertainty>(value);
                    OnPropertyChanged("Certainty");
                }
            }
            
            /// <summary>
            /// Clinical symptoms/signs associated with the Event
            /// </summary>
            [FhirElement("manifestation", Order=60)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> Manifestation
            {
                get { if(_Manifestation==null) _Manifestation = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Manifestation; }
                set { _Manifestation = value; OnPropertyChanged("Manifestation"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _Manifestation;
            
            /// <summary>
            /// Description of the event as a whole
            /// </summary>
            [FhirElement("description", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString DescriptionElement
            {
                get { return _DescriptionElement; }
                set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _DescriptionElement;
            
            /// <summary>
            /// Description of the event as a whole
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Description
            {
                get { return DescriptionElement != null ? DescriptionElement.Value : null; }
                set
                {
                    if (value == null)
                        DescriptionElement = null; 
                    else
                        DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Description");
                }
            }
            
            /// <summary>
            /// Date(/time) when manifestations showed
            /// </summary>
            [FhirElement("onset", Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.FhirDateTime OnsetElement
            {
                get { return _OnsetElement; }
                set { _OnsetElement = value; OnPropertyChanged("OnsetElement"); }
            }
            
            private Hl7.Fhir.Model.FhirDateTime _OnsetElement;
            
            /// <summary>
            /// Date(/time) when manifestations showed
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Onset
            {
                get { return OnsetElement != null ? OnsetElement.Value : null; }
                set
                {
                    if (value == null)
                        OnsetElement = null; 
                    else
                        OnsetElement = new Hl7.Fhir.Model.FhirDateTime(value);
                    OnPropertyChanged("Onset");
                }
            }
            
            /// <summary>
            /// mild | moderate | severe (of event as a whole)
            /// </summary>
            [FhirElement("severity", Order=90)]
            [DataMember]
            public Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceSeverity> SeverityElement
            {
                get { return _SeverityElement; }
                set { _SeverityElement = value; OnPropertyChanged("SeverityElement"); }
            }
            
            private Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceSeverity> _SeverityElement;
            
            /// <summary>
            /// mild | moderate | severe (of event as a whole)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceSeverity? Severity
            {
                get { return SeverityElement != null ? SeverityElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        SeverityElement = null; 
                    else
                        SeverityElement = new Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceSeverity>(value);
                    OnPropertyChanged("Severity");
                }
            }
            
            /// <summary>
            /// How the subject was exposed to the substance
            /// </summary>
            [FhirElement("exposureRoute", Order=100)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept ExposureRoute
            {
                get { return _ExposureRoute; }
                set { _ExposureRoute = value; OnPropertyChanged("ExposureRoute"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _ExposureRoute;
            
            /// <summary>
            /// Text about event not captured in other fields
            /// </summary>
            [FhirElement("note", Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.Annotation> Note
            {
                get { if(_Note==null) _Note = new List<Hl7.Fhir.Model.Annotation>(); return _Note; }
                set { _Note = value; OnPropertyChanged("Note"); }
            }
            
            private List<Hl7.Fhir.Model.Annotation> _Note;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ReactionComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Substance != null) dest.Substance = (Hl7.Fhir.Model.CodeableConcept)Substance.DeepCopy();
                    if(CertaintyElement != null) dest.CertaintyElement = (Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceCertainty>)CertaintyElement.DeepCopy();
                    if(Manifestation != null) dest.Manifestation = new List<Hl7.Fhir.Model.CodeableConcept>(Manifestation.DeepCopy());
                    if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                    if(OnsetElement != null) dest.OnsetElement = (Hl7.Fhir.Model.FhirDateTime)OnsetElement.DeepCopy();
                    if(SeverityElement != null) dest.SeverityElement = (Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceSeverity>)SeverityElement.DeepCopy();
                    if(ExposureRoute != null) dest.ExposureRoute = (Hl7.Fhir.Model.CodeableConcept)ExposureRoute.DeepCopy();
                    if(Note != null) dest.Note = new List<Hl7.Fhir.Model.Annotation>(Note.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ReactionComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ReactionComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Substance, otherT.Substance)) return false;
                if( !DeepComparable.Matches(CertaintyElement, otherT.CertaintyElement)) return false;
                if( !DeepComparable.Matches(Manifestation, otherT.Manifestation)) return false;
                if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.Matches(OnsetElement, otherT.OnsetElement)) return false;
                if( !DeepComparable.Matches(SeverityElement, otherT.SeverityElement)) return false;
                if( !DeepComparable.Matches(ExposureRoute, otherT.ExposureRoute)) return false;
                if( !DeepComparable.Matches(Note, otherT.Note)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ReactionComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Substance, otherT.Substance)) return false;
                if( !DeepComparable.IsExactly(CertaintyElement, otherT.CertaintyElement)) return false;
                if( !DeepComparable.IsExactly(Manifestation, otherT.Manifestation)) return false;
                if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.IsExactly(OnsetElement, otherT.OnsetElement)) return false;
                if( !DeepComparable.IsExactly(SeverityElement, otherT.SeverityElement)) return false;
                if( !DeepComparable.IsExactly(ExposureRoute, otherT.ExposureRoute)) return false;
                if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    // BackboneElement elements
                    foreach (var elem in ModifierExtension) { if (elem != null) yield return elem; }
                    // ReactionComponent elements
                    if (Substance != null) yield return Substance;
                    if (CertaintyElement != null) yield return CertaintyElement;
                    foreach (var elem in Manifestation) { if (elem != null) yield return elem; }
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (OnsetElement != null) yield return OnsetElement;
                    if (SeverityElement != null) yield return SeverityElement;
                    if (ExposureRoute != null) yield return ExposureRoute;
                    foreach (var elem in Note) { if (elem != null) yield return elem; }
                }
            }
            
        }
        
        
        /// <summary>
        /// External ids for this item
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.Identifier> _Identifier;
        
        /// <summary>
        /// active | inactive | resolved
        /// </summary>
        [FhirElement("clinicalStatus", InSummary=true, Order=100)]
        [DataMember]
        public Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceClinicalStatus> ClinicalStatusElement
        {
            get { return _ClinicalStatusElement; }
            set { _ClinicalStatusElement = value; OnPropertyChanged("ClinicalStatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceClinicalStatus> _ClinicalStatusElement;
        
        /// <summary>
        /// active | inactive | resolved
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceClinicalStatus? ClinicalStatus
        {
            get { return ClinicalStatusElement != null ? ClinicalStatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  ClinicalStatusElement = null; 
                else
                  ClinicalStatusElement = new Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceClinicalStatus>(value);
                OnPropertyChanged("ClinicalStatus");
            }
        }
        
        /// <summary>
        /// unconfirmed | confirmed | refuted | entered-in-error
        /// </summary>
        [FhirElement("verificationStatus", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceVerificationStatus> VerificationStatusElement
        {
            get { return _VerificationStatusElement; }
            set { _VerificationStatusElement = value; OnPropertyChanged("VerificationStatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceVerificationStatus> _VerificationStatusElement;
        
        /// <summary>
        /// unconfirmed | confirmed | refuted | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceVerificationStatus? VerificationStatus
        {
            get { return VerificationStatusElement != null ? VerificationStatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  VerificationStatusElement = null; 
                else
                  VerificationStatusElement = new Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceVerificationStatus>(value);
                OnPropertyChanged("VerificationStatus");
            }
        }
        
        /// <summary>
        /// allergy | intolerance - Underlying mechanism (if known)
        /// </summary>
        [FhirElement("type", InSummary=true, Order=120)]
        [DataMember]
        public Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceType> TypeElement
        {
            get { return _TypeElement; }
            set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
        }
        
        private Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceType> _TypeElement;
        
        /// <summary>
        /// allergy | intolerance - Underlying mechanism (if known)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceType? Type
        {
            get { return TypeElement != null ? TypeElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  TypeElement = null; 
                else
                  TypeElement = new Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceType>(value);
                OnPropertyChanged("Type");
            }
        }
        
        /// <summary>
        /// food | medication | biologic | environment
        /// </summary>
        [FhirElement("category", InSummary=true, Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceCategory>> CategoryElement
        {
            get { if(_CategoryElement==null) _CategoryElement = new List<Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceCategory>>(); return _CategoryElement; }
            set { _CategoryElement = value; OnPropertyChanged("CategoryElement"); }
        }
        
        private List<Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceCategory>> _CategoryElement;
        
        /// <summary>
        /// food | medication | biologic | environment
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public IEnumerable<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceCategory?> Category
        {
            get { return CategoryElement != null ? CategoryElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                  CategoryElement = null; 
                else
                  CategoryElement = new List<Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceCategory>>(value.Select(elem=>new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceCategory>(elem)));
                OnPropertyChanged("Category");
            }
        }
        
        /// <summary>
        /// low | high | unable-to-assess
        /// </summary>
        [FhirElement("criticality", InSummary=true, Order=140)]
        [DataMember]
        public Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceCriticality> CriticalityElement
        {
            get { return _CriticalityElement; }
            set { _CriticalityElement = value; OnPropertyChanged("CriticalityElement"); }
        }
        
        private Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceCriticality> _CriticalityElement;
        
        /// <summary>
        /// low | high | unable-to-assess
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceCriticality? Criticality
        {
            get { return CriticalityElement != null ? CriticalityElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  CriticalityElement = null; 
                else
                  CriticalityElement = new Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceCriticality>(value);
                OnPropertyChanged("Criticality");
            }
        }
        
        /// <summary>
        /// Allergy or intolerance code
        /// </summary>
        [FhirElement("code", InSummary=true, Order=150)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Code
        {
            get { return _Code; }
            set { _Code = value; OnPropertyChanged("Code"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Code;
        
        /// <summary>
        /// Who the sensitivity is for
        /// </summary>
        [FhirElement("patient", InSummary=true, Order=160)]
        [References("Patient")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Patient
        {
            get { return _Patient; }
            set { _Patient = value; OnPropertyChanged("Patient"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Patient;
        
        /// <summary>
        /// When allergy or intolerance was identified
        /// </summary>
        [FhirElement("onset", Order=170, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.FhirDateTime),typeof(Age),typeof(Hl7.Fhir.Model.Period),typeof(Hl7.Fhir.Model.Range),typeof(Hl7.Fhir.Model.FhirString))]
        [DataMember]
        public Hl7.Fhir.Model.Element Onset
        {
            get { return _Onset; }
            set { _Onset = value; OnPropertyChanged("Onset"); }
        }
        
        private Hl7.Fhir.Model.Element _Onset;
        
        /// <summary>
        /// Date record was believed accurate
        /// </summary>
        [FhirElement("assertedDate", Order=180)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime AssertedDateElement
        {
            get { return _AssertedDateElement; }
            set { _AssertedDateElement = value; OnPropertyChanged("AssertedDateElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _AssertedDateElement;
        
        /// <summary>
        /// Date record was believed accurate
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string AssertedDate
        {
            get { return AssertedDateElement != null ? AssertedDateElement.Value : null; }
            set
            {
                if (value == null)
                  AssertedDateElement = null; 
                else
                  AssertedDateElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("AssertedDate");
            }
        }
        
        /// <summary>
        /// Who recorded the sensitivity
        /// </summary>
        [FhirElement("recorder", Order=190)]
        [References("Practitioner","Patient")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Recorder
        {
            get { return _Recorder; }
            set { _Recorder = value; OnPropertyChanged("Recorder"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Recorder;
        
        /// <summary>
        /// Source of the information about the allergy
        /// </summary>
        [FhirElement("asserter", InSummary=true, Order=200)]
        [References("Patient","RelatedPerson","Practitioner")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Asserter
        {
            get { return _Asserter; }
            set { _Asserter = value; OnPropertyChanged("Asserter"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Asserter;
        
        /// <summary>
        /// Date(/time) of last known occurrence of a reaction
        /// </summary>
        [FhirElement("lastOccurrence", Order=210)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime LastOccurrenceElement
        {
            get { return _LastOccurrenceElement; }
            set { _LastOccurrenceElement = value; OnPropertyChanged("LastOccurrenceElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _LastOccurrenceElement;
        
        /// <summary>
        /// Date(/time) of last known occurrence of a reaction
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string LastOccurrence
        {
            get { return LastOccurrenceElement != null ? LastOccurrenceElement.Value : null; }
            set
            {
                if (value == null)
                  LastOccurrenceElement = null; 
                else
                  LastOccurrenceElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("LastOccurrence");
            }
        }
        
        /// <summary>
        /// Additional text not captured in other fields
        /// </summary>
        [FhirElement("note", Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Annotation> Note
        {
            get { if(_Note==null) _Note = new List<Hl7.Fhir.Model.Annotation>(); return _Note; }
            set { _Note = value; OnPropertyChanged("Note"); }
        }
        
        private List<Hl7.Fhir.Model.Annotation> _Note;
        
        /// <summary>
        /// Adverse Reaction Events linked to exposure to substance
        /// </summary>
        [FhirElement("reaction", Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.AllergyIntolerance.ReactionComponent> Reaction
        {
            get { if(_Reaction==null) _Reaction = new List<Hl7.Fhir.Model.AllergyIntolerance.ReactionComponent>(); return _Reaction; }
            set { _Reaction = value; OnPropertyChanged("Reaction"); }
        }
        
        private List<Hl7.Fhir.Model.AllergyIntolerance.ReactionComponent> _Reaction;
        

        public static ElementDefinition.ConstraintComponent AllergyIntolerance_AIT_1 = new ElementDefinition.ConstraintComponent()
        {
            Expression = "verificationStatus='entered-in-error' or clinicalStatus.exists()",
            Key = "ait-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "AllergyIntolerance.clinicalStatus SHALL be present if verificationStatus is not entered-in-error.",
            Xpath = "f:verificationStatus/@value='entered-in-error' or exists(f:clinicalStatus)"
        };

        public static ElementDefinition.ConstraintComponent AllergyIntolerance_AIT_2 = new ElementDefinition.ConstraintComponent()
        {
            Expression = "verificationStatus!='entered-in-error' or clinicalStatus.empty()",
            Key = "ait-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "AllergyIntolerance.clinicalStatus SHALL NOT be present if verification Status is entered-in-error",
            Xpath = "f:verificationStatus/@value!='entered-in-error' or not(exists(f:clinicalStatus))"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(AllergyIntolerance_AIT_1);
            InvariantConstraints.Add(AllergyIntolerance_AIT_2);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as AllergyIntolerance;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(ClinicalStatusElement != null) dest.ClinicalStatusElement = (Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceClinicalStatus>)ClinicalStatusElement.DeepCopy();
                if(VerificationStatusElement != null) dest.VerificationStatusElement = (Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceVerificationStatus>)VerificationStatusElement.DeepCopy();
                if(TypeElement != null) dest.TypeElement = (Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceType>)TypeElement.DeepCopy();
                if(CategoryElement != null) dest.CategoryElement = new List<Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceCategory>>(CategoryElement.DeepCopy());
                if(CriticalityElement != null) dest.CriticalityElement = (Code<Hl7.Fhir.Model.AllergyIntolerance.AllergyIntoleranceCriticality>)CriticalityElement.DeepCopy();
                if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
                if(Patient != null) dest.Patient = (Hl7.Fhir.Model.ResourceReference)Patient.DeepCopy();
                if(Onset != null) dest.Onset = (Hl7.Fhir.Model.Element)Onset.DeepCopy();
                if(AssertedDateElement != null) dest.AssertedDateElement = (Hl7.Fhir.Model.FhirDateTime)AssertedDateElement.DeepCopy();
                if(Recorder != null) dest.Recorder = (Hl7.Fhir.Model.ResourceReference)Recorder.DeepCopy();
                if(Asserter != null) dest.Asserter = (Hl7.Fhir.Model.ResourceReference)Asserter.DeepCopy();
                if(LastOccurrenceElement != null) dest.LastOccurrenceElement = (Hl7.Fhir.Model.FhirDateTime)LastOccurrenceElement.DeepCopy();
                if(Note != null) dest.Note = new List<Hl7.Fhir.Model.Annotation>(Note.DeepCopy());
                if(Reaction != null) dest.Reaction = new List<Hl7.Fhir.Model.AllergyIntolerance.ReactionComponent>(Reaction.DeepCopy());
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new AllergyIntolerance());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as AllergyIntolerance;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(ClinicalStatusElement, otherT.ClinicalStatusElement)) return false;
            if( !DeepComparable.Matches(VerificationStatusElement, otherT.VerificationStatusElement)) return false;
            if( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            if( !DeepComparable.Matches(CategoryElement, otherT.CategoryElement)) return false;
            if( !DeepComparable.Matches(CriticalityElement, otherT.CriticalityElement)) return false;
            if( !DeepComparable.Matches(Code, otherT.Code)) return false;
            if( !DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if( !DeepComparable.Matches(Onset, otherT.Onset)) return false;
            if( !DeepComparable.Matches(AssertedDateElement, otherT.AssertedDateElement)) return false;
            if( !DeepComparable.Matches(Recorder, otherT.Recorder)) return false;
            if( !DeepComparable.Matches(Asserter, otherT.Asserter)) return false;
            if( !DeepComparable.Matches(LastOccurrenceElement, otherT.LastOccurrenceElement)) return false;
            if( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if( !DeepComparable.Matches(Reaction, otherT.Reaction)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as AllergyIntolerance;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(ClinicalStatusElement, otherT.ClinicalStatusElement)) return false;
            if( !DeepComparable.IsExactly(VerificationStatusElement, otherT.VerificationStatusElement)) return false;
            if( !DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if( !DeepComparable.IsExactly(CategoryElement, otherT.CategoryElement)) return false;
            if( !DeepComparable.IsExactly(CriticalityElement, otherT.CriticalityElement)) return false;
            if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if( !DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if( !DeepComparable.IsExactly(Onset, otherT.Onset)) return false;
            if( !DeepComparable.IsExactly(AssertedDateElement, otherT.AssertedDateElement)) return false;
            if( !DeepComparable.IsExactly(Recorder, otherT.Recorder)) return false;
            if( !DeepComparable.IsExactly(Asserter, otherT.Asserter)) return false;
            if( !DeepComparable.IsExactly(LastOccurrenceElement, otherT.LastOccurrenceElement)) return false;
            if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if( !DeepComparable.IsExactly(Reaction, otherT.Reaction)) return false;
            
            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
				// AllergyIntolerance elements
				foreach (var elem in Identifier) { if (elem != null) yield return elem; }
				if (ClinicalStatusElement != null) yield return ClinicalStatusElement;
				if (VerificationStatusElement != null) yield return VerificationStatusElement;
				if (TypeElement != null) yield return TypeElement;
				foreach (var elem in CategoryElement) { if (elem != null) yield return elem; }
				if (CriticalityElement != null) yield return CriticalityElement;
				if (Code != null) yield return Code;
				if (Patient != null) yield return Patient;
				if (Onset != null) yield return Onset;
				if (AssertedDateElement != null) yield return AssertedDateElement;
				if (Recorder != null) yield return Recorder;
				if (Asserter != null) yield return Asserter;
				if (LastOccurrenceElement != null) yield return LastOccurrenceElement;
				foreach (var elem in Note) { if (elem != null) yield return elem; }
				foreach (var elem in Reaction) { if (elem != null) yield return elem; }
            }
        }
    }
    
}