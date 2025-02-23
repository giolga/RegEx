# RegEx
CHARACTER ESCAPES
\t 		- Matches a tab
\n 		- Matches a new line

CHARACTER CLASSES
.       - Wildcard: Matches any single character except \n.
\d      - Matches any decimal digit. (0-9)
\D      - Matches any character other than a decimal digit. (0-9)
\w      - Word Character (a-z, A-Z, 0-9, _)
\W      - Not a Word Character
\s      - Matches any white-space character. (space, tab, newline)
\S      - Matches any non-white-space character (space, tab, newline)
[character_group]     - Matches any single character in character_group. By default, the match is case-sensitive.
[^character_group]    - Negation: Matches any single character that is not in character_group. By default, characters in character_group are case-sensitive.

ANCHORS
^       - The match must start at the beginning of the string or line.
$       - The match must occur at the end of the string or before \n at the end of the line or string.
\A		- The match must occur at the start of the string.
\Z 		- The match must occur at the end of the string or before \n at the end of the string.
\b      - Word Boundary
\B      - Not a Word Boundary

ALTERNATION CONSTRUCTS
|       - Either Or

GROUPING CONSTRUCT
( )     - Group

Quantifiers:
*       - Matches the previous element zero or more times.
+       - Matches the previous element one or more times.
?       - Matches the previous element zero or one time.
{n}     - Matches the previous element exactly n times.
{n,m}   - Matches the previous element at least n times, but no more than m times.


