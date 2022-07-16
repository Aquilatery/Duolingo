#region Imports

using NJJPA = Newtonsoft.Json.JsonPropertyAttribute;
using SCG = System.Collections.Generic;
using SCGLO = System.Collections.Generic.List<object>;
using SCGLS = System.Collections.Generic.List<string>;
using SDT = System.DateTime;

#endregion

namespace Duolingo.Model
{
    #region Vocabulary

    /// <summary>
    /// 
    /// </summary>
    public class Vocabulary
    {
        /// <summary>
        /// 
        /// </summary>
        public class Tenses
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public class LanguageInformation
        {
            /// <summary>
            /// 
            /// </summary>
            [NJJPA("pronoun_mapping")]
            public SCGLO PronounMapping { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("tenses")]
            public Tenses Tenses { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class VocabOverview
        {
            /// <summary>
            /// 
            /// </summary>
            [NJJPA("strength_bars")]
            public int StrengthBars { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("infinitive")]
            public object Infinitive { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("normalized_string")]
            public string NormalizedString { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("pos")]
            public string Pos { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("last_practiced_ms")]
            public object LastPracticedMs { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("skill")]
            public string Skill { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("related_lexemes")]
            public SCGLS RelatedLexemes { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("last_practiced")]
            public SDT LastPracticed { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("strength")]
            public double Strength { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("skill_url_title")]
            public string SkillUrlTitle { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("gender")]
            public string Gender { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("id")]
            public string Id { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("lexeme_id")]
            public string LexemeId { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("word_string")]
            public string WordString { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class Root
        {
            /// <summary>
            /// 
            /// </summary>
            [NJJPA("language_string")]
            public string LanguageString { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("learning_language")]
            public string LearningLanguage { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("from_language")]
            public string FromLanguage { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("language_information")]
            public LanguageInformation LanguageInformation { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("vocab_overview")]
            public SCG.List<VocabOverview> VocabOverview { get; set; }
        }
    }

    #endregion
}