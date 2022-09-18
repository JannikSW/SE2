@echo off
rem Compiles the document completely, including references, bibliography, and glossaries/acronyms.
pdflatex 000_Praxisbericht.tex
bibtex 000_Praxisbericht
makeglossaries 000_Praxisbericht

rem Call pdflatex twice after completing bibtex and makeglossaries, see also BibTeX and glossaries package documentation.
pdflatex 000_Praxisbericht.tex
pdflatex 000_Praxisbericht.tex
