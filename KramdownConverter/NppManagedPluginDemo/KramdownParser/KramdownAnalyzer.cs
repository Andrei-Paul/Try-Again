/*
 * KramdownAnalyzer.cs
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

using PerCederberg.Grammatica.Runtime;

/**
 * <remarks>A class providing callback methods for the
 * parser.</remarks>
 */
public abstract class KramdownAnalyzer : Analyzer {

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public override void Enter(Node node) {
        switch (node.Id) {
        case (int) KramdownConstants.FIRST_HEADER_MARKER:
            EnterFirstHeaderMarker((Token) node);
            break;
        case (int) KramdownConstants.SECOND_HEADER_MARKER:
            EnterSecondHeaderMarker((Token) node);
            break;
        case (int) KramdownConstants.ATX_HEADER_L1:
            EnterAtxHeaderL1((Token) node);
            break;
        case (int) KramdownConstants.ATX_HEADER_L2:
            EnterAtxHeaderL2((Token) node);
            break;
        case (int) KramdownConstants.ATX_HEADER_L3:
            EnterAtxHeaderL3((Token) node);
            break;
        case (int) KramdownConstants.ATX_HEADER_L4:
            EnterAtxHeaderL4((Token) node);
            break;
        case (int) KramdownConstants.ATX_HEADER_L5:
            EnterAtxHeaderL5((Token) node);
            break;
        case (int) KramdownConstants.ATX_HEADER_L6:
            EnterAtxHeaderL6((Token) node);
            break;
        case (int) KramdownConstants.ATX_HEADER_END:
            EnterAtxHeaderEnd((Token) node);
            break;
        case (int) KramdownConstants.HEADERID_START:
            EnterHeaderidStart((Token) node);
            break;
        case (int) KramdownConstants.HEADERID_END:
            EnterHeaderidEnd((Token) node);
            break;
        case (int) KramdownConstants.BLOCKQUOTE_CHAR:
            EnterBlockquoteChar((Token) node);
            break;
        case (int) KramdownConstants.FENCED_CODEBLOCK_MARKER:
            EnterFencedCodeblockMarker((Token) node);
            break;
        case (int) KramdownConstants.EOB_MARKER:
            EnterEobMarker((Token) node);
            break;
        case (int) KramdownConstants.IAL_MARKER:
            EnterIalMarker((Token) node);
            break;
        case (int) KramdownConstants.LEFT_BRACE:
            EnterLeftBrace((Token) node);
            break;
        case (int) KramdownConstants.RIGHT_BRACE:
            EnterRightBrace((Token) node);
            break;
        case (int) KramdownConstants.UNORDERED_LIST_MARKER:
            EnterUnorderedListMarker((Token) node);
            break;
        case (int) KramdownConstants.ORDERED_LIST_MARKER:
            EnterOrderedListMarker((Token) node);
            break;
        case (int) KramdownConstants.TAB:
            EnterTab((Token) node);
            break;
        case (int) KramdownConstants.DEFINITION_MARKER:
            EnterDefinitionMarker((Token) node);
            break;
        case (int) KramdownConstants.TABLE_ROW:
            EnterTableRow((Token) node);
            break;
        case (int) KramdownConstants.SEPARATOR_LINE:
            EnterSeparatorLine((Token) node);
            break;
        case (int) KramdownConstants.FOOTER_SEPARATOR_LINE:
            EnterFooterSeparatorLine((Token) node);
            break;
        case (int) KramdownConstants.TEXT_LINE:
            EnterTextLine((Token) node);
            break;
        case (int) KramdownConstants.BLANK_LINE:
            EnterBlankLine((Token) node);
            break;
        case (int) KramdownConstants.NON_WHITESPACE:
            EnterNonWhitespace((Token) node);
            break;
        case (int) KramdownConstants.LETTER:
            EnterLetter((Token) node);
            break;
        case (int) KramdownConstants.DIGIT:
            EnterDigit((Token) node);
            break;
        case (int) KramdownConstants.EOL:
            EnterEol((Token) node);
            break;
        case (int) KramdownConstants.WHITESPACE:
            EnterWhitespace((Token) node);
            break;
        case (int) KramdownConstants.BLOCK:
            EnterBlock((Production) node);
            break;
        case (int) KramdownConstants.EO_B:
            EnterEoB((Production) node);
            break;
        case (int) KramdownConstants.ELEMENTS:
            EnterElements((Production) node);
            break;
        case (int) KramdownConstants.PARAGRAPH:
            EnterParagraph((Production) node);
            break;
        case (int) KramdownConstants.BLOCK_QUOTE:
            EnterBlockQuote((Production) node);
            break;
        case (int) KramdownConstants.FENCED_CODEBLOCK:
            EnterFencedCodeblock((Production) node);
            break;
        case (int) KramdownConstants.SETEXT_HEADER:
            EnterSetextHeader((Production) node);
            break;
        case (int) KramdownConstants.SETEXT_FIRST_LEVEL:
            EnterSetextFirstLevel((Production) node);
            break;
        case (int) KramdownConstants.SETEXT_SECOND_LEVEL:
            EnterSetextSecondLevel((Production) node);
            break;
        case (int) KramdownConstants.ATX_HEADER:
            EnterAtxHeader((Production) node);
            break;
        case (int) KramdownConstants.HEADER_ID:
            EnterHeaderId((Production) node);
            break;
        case (int) KramdownConstants.ORDERED_LIST:
            EnterOrderedList((Production) node);
            break;
        case (int) KramdownConstants.UNORDERED_LIST:
            EnterUnorderedList((Production) node);
            break;
        }
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public override Node Exit(Node node) {
        switch (node.Id) {
        case (int) KramdownConstants.FIRST_HEADER_MARKER:
            return ExitFirstHeaderMarker((Token) node);
        case (int) KramdownConstants.SECOND_HEADER_MARKER:
            return ExitSecondHeaderMarker((Token) node);
        case (int) KramdownConstants.ATX_HEADER_L1:
            return ExitAtxHeaderL1((Token) node);
        case (int) KramdownConstants.ATX_HEADER_L2:
            return ExitAtxHeaderL2((Token) node);
        case (int) KramdownConstants.ATX_HEADER_L3:
            return ExitAtxHeaderL3((Token) node);
        case (int) KramdownConstants.ATX_HEADER_L4:
            return ExitAtxHeaderL4((Token) node);
        case (int) KramdownConstants.ATX_HEADER_L5:
            return ExitAtxHeaderL5((Token) node);
        case (int) KramdownConstants.ATX_HEADER_L6:
            return ExitAtxHeaderL6((Token) node);
        case (int) KramdownConstants.ATX_HEADER_END:
            return ExitAtxHeaderEnd((Token) node);
        case (int) KramdownConstants.HEADERID_START:
            return ExitHeaderidStart((Token) node);
        case (int) KramdownConstants.HEADERID_END:
            return ExitHeaderidEnd((Token) node);
        case (int) KramdownConstants.BLOCKQUOTE_CHAR:
            return ExitBlockquoteChar((Token) node);
        case (int) KramdownConstants.FENCED_CODEBLOCK_MARKER:
            return ExitFencedCodeblockMarker((Token) node);
        case (int) KramdownConstants.EOB_MARKER:
            return ExitEobMarker((Token) node);
        case (int) KramdownConstants.IAL_MARKER:
            return ExitIalMarker((Token) node);
        case (int) KramdownConstants.LEFT_BRACE:
            return ExitLeftBrace((Token) node);
        case (int) KramdownConstants.RIGHT_BRACE:
            return ExitRightBrace((Token) node);
        case (int) KramdownConstants.UNORDERED_LIST_MARKER:
            return ExitUnorderedListMarker((Token) node);
        case (int) KramdownConstants.ORDERED_LIST_MARKER:
            return ExitOrderedListMarker((Token) node);
        case (int) KramdownConstants.TAB:
            return ExitTab((Token) node);
        case (int) KramdownConstants.DEFINITION_MARKER:
            return ExitDefinitionMarker((Token) node);
        case (int) KramdownConstants.TABLE_ROW:
            return ExitTableRow((Token) node);
        case (int) KramdownConstants.SEPARATOR_LINE:
            return ExitSeparatorLine((Token) node);
        case (int) KramdownConstants.FOOTER_SEPARATOR_LINE:
            return ExitFooterSeparatorLine((Token) node);
        case (int) KramdownConstants.TEXT_LINE:
            return ExitTextLine((Token) node);
        case (int) KramdownConstants.BLANK_LINE:
            return ExitBlankLine((Token) node);
        case (int) KramdownConstants.NON_WHITESPACE:
            return ExitNonWhitespace((Token) node);
        case (int) KramdownConstants.LETTER:
            return ExitLetter((Token) node);
        case (int) KramdownConstants.DIGIT:
            return ExitDigit((Token) node);
        case (int) KramdownConstants.EOL:
            return ExitEol((Token) node);
        case (int) KramdownConstants.WHITESPACE:
            return ExitWhitespace((Token) node);
        case (int) KramdownConstants.BLOCK:
            return ExitBlock((Production) node);
        case (int) KramdownConstants.EO_B:
            return ExitEoB((Production) node);
        case (int) KramdownConstants.ELEMENTS:
            return ExitElements((Production) node);
        case (int) KramdownConstants.PARAGRAPH:
            return ExitParagraph((Production) node);
        case (int) KramdownConstants.BLOCK_QUOTE:
            return ExitBlockQuote((Production) node);
        case (int) KramdownConstants.FENCED_CODEBLOCK:
            return ExitFencedCodeblock((Production) node);
        case (int) KramdownConstants.SETEXT_HEADER:
            return ExitSetextHeader((Production) node);
        case (int) KramdownConstants.SETEXT_FIRST_LEVEL:
            return ExitSetextFirstLevel((Production) node);
        case (int) KramdownConstants.SETEXT_SECOND_LEVEL:
            return ExitSetextSecondLevel((Production) node);
        case (int) KramdownConstants.ATX_HEADER:
            return ExitAtxHeader((Production) node);
        case (int) KramdownConstants.HEADER_ID:
            return ExitHeaderId((Production) node);
        case (int) KramdownConstants.ORDERED_LIST:
            return ExitOrderedList((Production) node);
        case (int) KramdownConstants.UNORDERED_LIST:
            return ExitUnorderedList((Production) node);
        }
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     *
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public override void Child(Production node, Node child) {
        switch (node.Id) {
        case (int) KramdownConstants.BLOCK:
            ChildBlock(node, child);
            break;
        case (int) KramdownConstants.EO_B:
            ChildEoB(node, child);
            break;
        case (int) KramdownConstants.ELEMENTS:
            ChildElements(node, child);
            break;
        case (int) KramdownConstants.PARAGRAPH:
            ChildParagraph(node, child);
            break;
        case (int) KramdownConstants.BLOCK_QUOTE:
            ChildBlockQuote(node, child);
            break;
        case (int) KramdownConstants.FENCED_CODEBLOCK:
            ChildFencedCodeblock(node, child);
            break;
        case (int) KramdownConstants.SETEXT_HEADER:
            ChildSetextHeader(node, child);
            break;
        case (int) KramdownConstants.SETEXT_FIRST_LEVEL:
            ChildSetextFirstLevel(node, child);
            break;
        case (int) KramdownConstants.SETEXT_SECOND_LEVEL:
            ChildSetextSecondLevel(node, child);
            break;
        case (int) KramdownConstants.ATX_HEADER:
            ChildAtxHeader(node, child);
            break;
        case (int) KramdownConstants.HEADER_ID:
            ChildHeaderId(node, child);
            break;
        case (int) KramdownConstants.ORDERED_LIST:
            ChildOrderedList(node, child);
            break;
        case (int) KramdownConstants.UNORDERED_LIST:
            ChildUnorderedList(node, child);
            break;
        }
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterFirstHeaderMarker(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitFirstHeaderMarker(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterSecondHeaderMarker(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitSecondHeaderMarker(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterAtxHeaderL1(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitAtxHeaderL1(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterAtxHeaderL2(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitAtxHeaderL2(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterAtxHeaderL3(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitAtxHeaderL3(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterAtxHeaderL4(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitAtxHeaderL4(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterAtxHeaderL5(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitAtxHeaderL5(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterAtxHeaderL6(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitAtxHeaderL6(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterAtxHeaderEnd(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitAtxHeaderEnd(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterHeaderidStart(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitHeaderidStart(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterHeaderidEnd(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitHeaderidEnd(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterBlockquoteChar(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitBlockquoteChar(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterFencedCodeblockMarker(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitFencedCodeblockMarker(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterEobMarker(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitEobMarker(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterIalMarker(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitIalMarker(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterLeftBrace(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitLeftBrace(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterRightBrace(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitRightBrace(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterUnorderedListMarker(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitUnorderedListMarker(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterOrderedListMarker(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitOrderedListMarker(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterTab(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitTab(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterDefinitionMarker(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitDefinitionMarker(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterTableRow(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitTableRow(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterSeparatorLine(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitSeparatorLine(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterFooterSeparatorLine(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitFooterSeparatorLine(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterTextLine(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitTextLine(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterBlankLine(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitBlankLine(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterNonWhitespace(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitNonWhitespace(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterLetter(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitLetter(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterDigit(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitDigit(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterEol(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitEol(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterWhitespace(Token node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitWhitespace(Token node) {
        return node;
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterBlock(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitBlock(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     *
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildBlock(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterEoB(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitEoB(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     *
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildEoB(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterElements(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitElements(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     *
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildElements(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterParagraph(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitParagraph(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     *
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildParagraph(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterBlockQuote(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitBlockQuote(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     *
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildBlockQuote(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterFencedCodeblock(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitFencedCodeblock(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     *
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildFencedCodeblock(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterSetextHeader(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitSetextHeader(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     *
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildSetextHeader(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterSetextFirstLevel(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitSetextFirstLevel(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     *
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildSetextFirstLevel(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterSetextSecondLevel(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitSetextSecondLevel(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     *
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildSetextSecondLevel(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterAtxHeader(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitAtxHeader(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     *
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildAtxHeader(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterHeaderId(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitHeaderId(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     *
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildHeaderId(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterOrderedList(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitOrderedList(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     *
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildOrderedList(Production node, Node child) {
        node.AddChild(child);
    }

    /**
     * <summary>Called when entering a parse tree node.</summary>
     *
     * <param name='node'>the node being entered</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void EnterUnorderedList(Production node) {
    }

    /**
     * <summary>Called when exiting a parse tree node.</summary>
     *
     * <param name='node'>the node being exited</param>
     *
     * <returns>the node to add to the parse tree, or
     *          null if no parse tree should be created</returns>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual Node ExitUnorderedList(Production node) {
        return node;
    }

    /**
     * <summary>Called when adding a child to a parse tree
     * node.</summary>
     *
     * <param name='node'>the parent node</param>
     * <param name='child'>the child node, or null</param>
     *
     * <exception cref='ParseException'>if the node analysis
     * discovered errors</exception>
     */
    public virtual void ChildUnorderedList(Production node, Node child) {
        node.AddChild(child);
    }
}
