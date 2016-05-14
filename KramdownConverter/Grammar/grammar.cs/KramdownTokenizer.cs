/*
 * KramdownTokenizer.cs
 *
 * THIS FILE HAS BEEN GENERATED AUTOMATICALLY. DO NOT EDIT!
 *
 * This program is free software: you can redistribute it and/or
 * modify it under the terms of the BSD license.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * LICENSE.txt file for more details.
 *
 * Copyright (c) 2016 Andrei Ghitea. All rights reserved.
 */

using System.IO;

using PerCederberg.Grammatica.Runtime;

/**
 * <remarks>A character stream tokenizer.</remarks>
 */
public class KramdownTokenizer : Tokenizer {

    /**
     * <summary>Creates a new tokenizer for the specified input
     * stream.</summary>
     *
     * <param name='input'>the input stream to read</param>
     *
     * <exception cref='ParserCreationException'>if the tokenizer
     * couldn't be initialized correctly</exception>
     */
    public KramdownTokenizer(TextReader input)
        : base(input, true) {

        CreatePatterns();
    }

    /**
     * <summary>Initializes the tokenizer by creating all the token
     * patterns.</summary>
     *
     * <exception cref='ParserCreationException'>if the tokenizer
     * couldn't be initialized correctly</exception>
     */
    private void CreatePatterns() {
        TokenPattern  pattern;

        pattern = new TokenPattern((int) KramdownConstants.FIRST_HEADER_MARKER,
                                   "FIRST_HEADER_MARKER",
                                   TokenPattern.PatternType.REGEXP,
                                   "[=]+");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.SECOND_HEADER_MARKER,
                                   "SECOND_HEADER_MARKER",
                                   TokenPattern.PatternType.REGEXP,
                                   "[-]+");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.ATX_HEADER_L1,
                                   "ATX_HEADER_L1",
                                   TokenPattern.PatternType.STRING,
                                   "#");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.ATX_HEADER_L2,
                                   "ATX_HEADER_L2",
                                   TokenPattern.PatternType.STRING,
                                   "##");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.ATX_HEADER_L3,
                                   "ATX_HEADER_L3",
                                   TokenPattern.PatternType.STRING,
                                   "###");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.ATX_HEADER_L4,
                                   "ATX_HEADER_L4",
                                   TokenPattern.PatternType.STRING,
                                   "####");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.ATX_HEADER_L5,
                                   "ATX_HEADER_L5",
                                   TokenPattern.PatternType.STRING,
                                   "#####");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.ATX_HEADER_L6,
                                   "ATX_HEADER_L6",
                                   TokenPattern.PatternType.STRING,
                                   "######");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.ATX_HEADER_END,
                                   "ATX_HEADER_END",
                                   TokenPattern.PatternType.REGEXP,
                                   "[#]*");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.HEADERID_START,
                                   "HEADERID_START",
                                   TokenPattern.PatternType.STRING,
                                   "{#");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.HEADERID_END,
                                   "HEADERID_END",
                                   TokenPattern.PatternType.STRING,
                                   "}");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.BLOCKQUOTE_CHAR,
                                   "BLOCKQUOTE_CHAR",
                                   TokenPattern.PatternType.STRING,
                                   ">");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.FENCED_CODEBLOCK_MARKER,
                                   "FENCED_CODEBLOCK_MARKER",
                                   TokenPattern.PatternType.REGEXP,
                                   "[~]{3,}");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.EOB_MARKER,
                                   "EOB_MARKER",
                                   TokenPattern.PatternType.STRING,
                                   "^");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.IAL_MARKER,
                                   "IAL_MARKER",
                                   TokenPattern.PatternType.STRING,
                                   ":");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.LEFT_BRACE,
                                   "LEFT_BRACE",
                                   TokenPattern.PatternType.STRING,
                                   "{");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.RIGHT_BRACE,
                                   "RIGHT_BRACE",
                                   TokenPattern.PatternType.STRING,
                                   "}");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.UNORDERED_LIST_MARKER,
                                   "UNORDERED_LIST_MARKER",
                                   TokenPattern.PatternType.STRING,
                                   "<<[+|-|*]>>");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.ORDERED_LIST_MARKER,
                                   "ORDERED_LIST_MARKER",
                                   TokenPattern.PatternType.REGEXP,
                                   "[0-9]+");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.TAB,
                                   "TAB",
                                   TokenPattern.PatternType.STRING,
                                   "\\t");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.DEFINITION_MARKER,
                                   "DEFINITION_MARKER",
                                   TokenPattern.PatternType.STRING,
                                   ":");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.TABLE_ROW,
                                   "TABLE_ROW",
                                   TokenPattern.PatternType.STRING,
                                   "|");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.SEPARATOR_LINE,
                                   "SEPARATOR_LINE",
                                   TokenPattern.PatternType.STRING,
                                   "-");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.FOOTER_SEPARATOR_LINE,
                                   "FOOTER_SEPARATOR_LINE",
                                   TokenPattern.PatternType.STRING,
                                   "=");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.TEXT_LINE,
                                   "TEXT_LINE",
                                   TokenPattern.PatternType.REGEXP,
                                   "[^ #>-+*].+");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.NEW_LINE,
                                   "NEW_LINE",
                                   TokenPattern.PatternType.REGEXP,
                                   "[\\r]?[\\n]{1}");
        pattern.Ignore = true;
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.BLANK_LINE,
                                   "BLANK_LINE",
                                   TokenPattern.PatternType.REGEXP,
                                   "[\\r]?[\\n]{1}[ \\t]*[\\r]?[\\n]{1}");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.IGNORE_WHITESPACE,
                                   "IGNORE_WHITESPACE",
                                   TokenPattern.PatternType.REGEXP,
                                   "[\\t ]*");
        pattern.Ignore = true;
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.NON_WHITESPACE,
                                   "NON_WHITESPACE",
                                   TokenPattern.PatternType.REGEXP,
                                   "[\\S]");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.LETTER,
                                   "LETTER",
                                   TokenPattern.PatternType.REGEXP,
                                   "[a-zA-Z]");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.DIGIT,
                                   "DIGIT",
                                   TokenPattern.PatternType.REGEXP,
                                   "[0-9]");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.EOL,
                                   "EOL",
                                   TokenPattern.PatternType.REGEXP,
                                   "[\\n][\\r]?");
        AddPattern(pattern);

        pattern = new TokenPattern((int) KramdownConstants.WHITESPACE,
                                   "WHITESPACE",
                                   TokenPattern.PatternType.REGEXP,
                                   "[ \\t]+");
        AddPattern(pattern);
    }
}
