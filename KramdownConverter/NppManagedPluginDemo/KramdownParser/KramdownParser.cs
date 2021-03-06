/*
 * KramdownParser.cs
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
 * <remarks>A token stream parser.</remarks>
 */
public class KramdownParser : RecursiveDescentParser {

    /**
     * <summary>An enumeration with the generated production node
     * identity constants.</summary>
     */
    private enum SynteticPatterns {
    }

    /**
     * <summary>Creates a new parser with a default analyzer.</summary>
     *
     * <param name='input'>the input stream to read from</param>
     *
     * <exception cref='ParserCreationException'>if the parser
     * couldn't be initialized correctly</exception>
     */
    public KramdownParser(TextReader input)
        : base(input) {

        CreatePatterns();
    }

    /**
     * <summary>Creates a new parser.</summary>
     *
     * <param name='input'>the input stream to read from</param>
     *
     * <param name='analyzer'>the analyzer to parse with</param>
     *
     * <exception cref='ParserCreationException'>if the parser
     * couldn't be initialized correctly</exception>
     */
    public KramdownParser(TextReader input, KramdownAnalyzer analyzer)
        : base(input, analyzer) {

        CreatePatterns();
    }

    /**
     * <summary>Creates a new tokenizer for this parser. Can be overridden
     * by a subclass to provide a custom implementation.</summary>
     *
     * <param name='input'>the input stream to read from</param>
     *
     * <returns>the tokenizer created</returns>
     *
     * <exception cref='ParserCreationException'>if the tokenizer
     * couldn't be initialized correctly</exception>
     */
    protected override Tokenizer NewTokenizer(TextReader input) {
        return new KramdownTokenizer(input);
    }

    /**
     * <summary>Initializes the parser by creating all the production
     * patterns.</summary>
     *
     * <exception cref='ParserCreationException'>if the parser
     * couldn't be initialized correctly</exception>
     */
    private void CreatePatterns() {
        ProductionPattern             pattern;
        ProductionPatternAlternative  alt;

        pattern = new ProductionPattern((int) KramdownConstants.BLOCK,
                                        "Block");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) KramdownConstants.ELEMENTS, 1, 1);
        alt.AddProduction((int) KramdownConstants.EO_B, 0, 1);
        alt.AddProduction((int) KramdownConstants.BLOCK, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) KramdownConstants.EO_B,
                                        "EoB");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) KramdownConstants.EOB_MARKER, 1, 1);
        alt.AddProduction((int) KramdownConstants.EO_B, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) KramdownConstants.BLANK_LINE, 1, 1);
        alt.AddProduction((int) KramdownConstants.EO_B, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) KramdownConstants.ELEMENTS,
                                        "Elements");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) KramdownConstants.BLOCK_QUOTE, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) KramdownConstants.ORDERED_LIST, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) KramdownConstants.UNORDERED_LIST, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) KramdownConstants.FENCED_CODEBLOCK, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) KramdownConstants.SETEXT_HEADER, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) KramdownConstants.ATX_HEADER, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) KramdownConstants.PARAGRAPH, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) KramdownConstants.PARAGRAPH,
                                        "Paragraph");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) KramdownConstants.TEXT_LINE, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) KramdownConstants.BLOCK_QUOTE,
                                        "BlockQuote");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) KramdownConstants.BLOCKQUOTE_CHAR, 1, 1);
        alt.AddProduction((int) KramdownConstants.PARAGRAPH, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) KramdownConstants.FENCED_CODEBLOCK,
                                        "FencedCodeblock");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) KramdownConstants.FENCED_CODEBLOCK_MARKER, 1, 1);
        alt.AddProduction((int) KramdownConstants.PARAGRAPH, 1, 1);
        alt.AddToken((int) KramdownConstants.FENCED_CODEBLOCK_MARKER, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) KramdownConstants.SETEXT_HEADER,
                                        "SetextHeader");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) KramdownConstants.SETEXT_FIRST_LEVEL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) KramdownConstants.SETEXT_SECOND_LEVEL, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) KramdownConstants.SETEXT_FIRST_LEVEL,
                                        "SetextFirstLevel");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) KramdownConstants.PARAGRAPH, 1, 1);
        alt.AddProduction((int) KramdownConstants.HEADER_ID, 0, 1);
        alt.AddToken((int) KramdownConstants.FIRST_HEADER_MARKER, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) KramdownConstants.SETEXT_SECOND_LEVEL,
                                        "SetextSecondLevel");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) KramdownConstants.PARAGRAPH, 1, 1);
        alt.AddProduction((int) KramdownConstants.HEADER_ID, 0, 1);
        alt.AddToken((int) KramdownConstants.SECOND_HEADER_MARKER, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) KramdownConstants.ATX_HEADER,
                                        "AtxHeader");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) KramdownConstants.ATX_HEADER_L1, 1, 1);
        alt.AddProduction((int) KramdownConstants.PARAGRAPH, 1, 1);
        alt.AddToken((int) KramdownConstants.ATX_HEADER_END, 0, 1);
        alt.AddProduction((int) KramdownConstants.HEADER_ID, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) KramdownConstants.ATX_HEADER_L2, 1, 1);
        alt.AddProduction((int) KramdownConstants.PARAGRAPH, 1, 1);
        alt.AddToken((int) KramdownConstants.ATX_HEADER_END, 0, 1);
        alt.AddProduction((int) KramdownConstants.HEADER_ID, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) KramdownConstants.ATX_HEADER_L3, 1, 1);
        alt.AddProduction((int) KramdownConstants.PARAGRAPH, 1, 1);
        alt.AddToken((int) KramdownConstants.ATX_HEADER_END, 0, 1);
        alt.AddProduction((int) KramdownConstants.HEADER_ID, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) KramdownConstants.ATX_HEADER_L4, 1, 1);
        alt.AddProduction((int) KramdownConstants.PARAGRAPH, 1, 1);
        alt.AddToken((int) KramdownConstants.ATX_HEADER_END, 0, 1);
        alt.AddProduction((int) KramdownConstants.HEADER_ID, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) KramdownConstants.ATX_HEADER_L5, 1, 1);
        alt.AddProduction((int) KramdownConstants.PARAGRAPH, 1, 1);
        alt.AddToken((int) KramdownConstants.ATX_HEADER_END, 0, 1);
        alt.AddProduction((int) KramdownConstants.HEADER_ID, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) KramdownConstants.ATX_HEADER_L6, 1, 1);
        alt.AddProduction((int) KramdownConstants.PARAGRAPH, 1, 1);
        alt.AddToken((int) KramdownConstants.ATX_HEADER_END, 0, 1);
        alt.AddProduction((int) KramdownConstants.HEADER_ID, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) KramdownConstants.HEADER_ID,
                                        "HeaderId");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) KramdownConstants.HEADERID_START, 1, 1);
        alt.AddProduction((int) KramdownConstants.PARAGRAPH, 1, 1);
        alt.AddToken((int) KramdownConstants.HEADERID_END, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) KramdownConstants.ORDERED_LIST,
                                        "OrderedList");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) KramdownConstants.ORDERED_LIST_MARKER, 1, 1);
        alt.AddToken((int) KramdownConstants.TEXT_LINE, 1, 1);
        alt.AddProduction((int) KramdownConstants.ORDERED_LIST, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) KramdownConstants.UNORDERED_LIST,
                                        "UnorderedList");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) KramdownConstants.UNORDERED_LIST_MARKER, 1, 1);
        alt.AddToken((int) KramdownConstants.TEXT_LINE, 1, 1);
        alt.AddProduction((int) KramdownConstants.UNORDERED_LIST, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);
    }
}
