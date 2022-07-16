#region Imports

using NJJPA = Newtonsoft.Json.JsonPropertyAttribute;
using SCG = System.Collections.Generic;
using SCGLO = System.Collections.Generic.List<object>;

#endregion

namespace Duolingo.Model
{
    #region Lexeme

    /// <summary>
    /// 
    /// </summary>
    public class Lexeme
    {
        /// <summary>
        /// 
        /// </summary>
        public class Discussion
        {
            /// <summary>
            /// 
            /// </summary>
            [NJJPA("url")]
            public string Url { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("num_comments")]
            public string NumComments { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class AlternativeForm
        {
            /// <summary>
            /// 
            /// </summary>
            [NJJPA("case")]
            public object Case { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("gender")]
            public object Gender { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("word")]
            public string Word { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("tts")]
            public string Tts { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("text")]
            public string Text { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("discussion")]
            public Lexeme.Discussion Discussion { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("number")]
            public object Number { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("invalid")]
            public object Invalid { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("highlighted")]
            public bool Highlighted { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("translation_text")]
            public string TranslationText { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("link")]
            public string Link { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("example_sentence")]
            public string ExampleSentence { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("word_value_matched")]
            public bool WordValueMatched { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("translation")]
            public string Translation { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class LanguageInformation
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public class RelatedDiscussion
        {
            /// <summary>
            /// 
            /// </summary>
            [NJJPA("url")]
            public string Url { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("num_comments")]
            public string NumComments { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("anchor")]
            public string Anchor { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class Root
        {
            /// <summary>
            /// 
            /// </summary>
            [NJJPA("alternative_forms")]
            public SCG.List<AlternativeForm> AlternativeForms { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("has_tts")]
            public bool HasTts { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("word")]
            public string Word { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("language_information")]
            public LanguageInformation LanguageInformation { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("from_language_name")]
            public string FromLanguageName { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("tts")]
            public string Tts { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("infinitive")]
            public object Infinitive { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("learning_language")]
            public string LearningLanguage { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("translations")]
            public string Translations { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("learning_language_name")]
            public string LearningLanguageName { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("pos")]
            public object Pos { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("lexeme_image")]
            public object LexemeImage { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("from_language")]
            public string FromLanguage { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("is_generic")]
            public bool IsGeneric { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("lexeme_id")]
            public string LexemeId { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("related_lexemes")]
            public SCGLO RelatedLexemes { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("related_discussions")]
            public SCG.List<RelatedDiscussion> RelatedDiscussions { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [NJJPA("canonical_path")]
            public string CanonicalPath { get; set; }
        }
    }

    #endregion
}
