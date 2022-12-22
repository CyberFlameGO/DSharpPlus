// This file is part of the DSharpPlus project.
//
// Copyright (c) 2015 Mike Santiago
// Copyright (c) 2016-2022 DSharpPlus Contributors
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System.Collections.Generic;
using System.Linq;
using System.Text;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Converters;
using DSharpPlus.CommandsNext.Entities;

namespace DSharpPlus.Test;

public sealed class TestBotHelpFormatter : BaseHelpFormatter
{
    private StringBuilder Content { get; }

    public TestBotHelpFormatter(CommandContext ctx)
        : base(ctx) => Content = new StringBuilder();

    public override BaseHelpFormatter WithCommand(Command command)
    {
        Content.Append(command.Description ?? "No description provided.").Append("\n\n");

        if (command.Aliases.Count > 0)
        {
            Content.Append("Aliases: ").Append(string.Join(", ", command.Aliases)).Append("\n\n");
        }

        if (command.Overloads.Count > 0)
        {
            StringBuilder sb = new StringBuilder();

            foreach (CommandOverload? ovl in command.Overloads.OrderByDescending(x => x.Priority))
            {
                sb.Append(command.QualifiedName);

                foreach (CommandArgument arg in ovl.Arguments)
                {
                    sb.Append(arg.IsOptional || arg.IsCatchAll ? " [" : " <").Append(arg.Name).Append(arg.IsCatchAll ? "..." : "").Append(arg.IsOptional || arg.IsCatchAll ? ']' : '>');
                }

                sb.Append('\n');

                foreach (CommandArgument arg in ovl.Arguments)
                {
                    sb.Append(arg.Name).Append(" (").Append(CommandsNext.GetUserFriendlyTypeName(arg.Type)).Append("): ").Append(arg.Description ?? "No description provided.").Append('\n');
                }

                sb.Append('\n');
            }

            Content.Append("Arguments:\n").Append(sb);
        }

        return this;
    }

    public override BaseHelpFormatter WithSubcommands(IEnumerable<Command> subcommands)
    {
        if (Content.Length == 0)
        {
            Content.Append("Displaying all available commands.\n\n");
        }
        else
        {
            Content.Append("Subcommands:\n");
        }

        if (subcommands?.Any() == true)
        {
            int ml = subcommands.Max(xc => xc.Name.Length);
            StringBuilder sb = new StringBuilder();
            foreach (Command xc in subcommands)
            {
                sb.Append(xc.Name.PadRight(ml, ' '))
                    .Append("  ")
                    .Append(string.IsNullOrWhiteSpace(xc.Description) ? "" : xc.Description).Append('\n');
            }

            Content.Append(sb);
        }

        return this;
    }

    public override CommandHelpMessage Build()
        => new CommandHelpMessage($"```less\n{Content.ToString().Trim()}\n```");
}
