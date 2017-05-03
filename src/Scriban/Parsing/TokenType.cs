// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license. See license.txt file in the project root for full license information.
namespace Scriban.Parsing
{
    /// <summary>
    /// An enumeration to categorize tokens.
    /// </summary>
    public enum TokenType
    {
        Invalid,

        FrontMatterMarker,

        [TokenText("{{")]
        CodeEnter,

        [TokenText("}}")]
        CodeExit,

        Raw,

        NewLine,

        Comment,

        CommentMulti,

        /// <summary>
        /// An identifier starting by a $
        /// </summary>
        IdentifierSpecial,

        /// <summary>
        /// An identifier
        /// </summary>
        Identifier,

        /// <summary>
        /// An integer (int, long...)
        /// </summary>
        Integer,

        /// <summary>
        /// A floating point number
        /// </summary>
        Float,

        /// <summary>
        /// A string
        /// </summary>
        String,

        /// <summary>
        /// A verbatim string
        /// </summary>
        VerbatimString,

        [TokenText(";")]
        SemiColon,

        [TokenText("@")]
        Arroba,

        [TokenText("^")]
        Caret,

        [TokenText(":")]
        Colon,

        [TokenText("=")]
        Equal,

        [TokenText("|")]
        Pipe,  // |

        [TokenText("!")]
        Not, // !

        [TokenText("&&")]
        And, // &&

        [TokenText("||")]
        Or,  // ||

        [TokenText("??")]
        EmptyCoalescing,

        [TokenText("==")]
        CompareEqual,

        [TokenText("!=")]
        CompareNotEqual,

        [TokenText("<")]
        CompareLess,

        [TokenText(">")]
        CompareGreater,

        [TokenText("<=")]
        CompareLessOrEqual,

        [TokenText(">=")]
        CompareGreaterOrEqual,

        [TokenText("/")]
        Divide,

        [TokenText("//")]
        DoubleDivide,

        [TokenText("*")]
        Multiply,

        [TokenText("+")]
        Plus,

        [TokenText("-")]
        Minus,

        [TokenText("%")]
        Modulus,

        [TokenText("<<")]
        ShiftLeft,

        [TokenText(">>")]
        ShiftRight,

        [TokenText(",")]
        Comma,

        [TokenText(".")]
        Dot,

        [TokenText("..")]
        DoubleDot,

        [TokenText("..<")]
        DoubleDotLess,

        [TokenText("(")]
        OpenParent,
        [TokenText(")")]
        CloseParent,

        [TokenText("{")]
        OpenBrace,
        [TokenText("}")]
        CloseBrace,

        [TokenText("[")]
        OpenBracket,
        [TokenText("]")]
        CloseBracket,

        Eof,
    }
}