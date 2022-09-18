@echo off
rem Compiles the document completely, including references, bibliography, and glossaries/acronyms.
pdflatex 000_Praxisbericht.tex
bibtex 000_Praxisbericht
makeglossaries 000_Praxisbericht

rem Call pdflatex twice after completing bibtex and makeglossaries, see also BibTeX and glossaries package documentation.
pdflatex 000_Praxisbericht.tex
pdflatex 000_Praxisbericht.tex

rem Delete all .aux files, delete intermediate 000_Praxisbericht.* files.
rem This script is separate in case of errors, so the user may inspect intermediately generated files.
del *.aux
del 000_Praxisbericht.acn
del 000_Praxisbericht.acr
del 000_Praxisbericht.alg
del 000_Praxisbericht.bbl
del 000_Praxisbericht.blg
del 000_Praxisbericht.glg
del 000_Praxisbericht.glo
del 000_Praxisbericht.gls
del 000_Praxisbericht.ist
del 000_Praxisbericht.lof
del 000_Praxisbericht.log
del 000_Praxisbericht.lol
del 000_Praxisbericht.lot
del 000_Praxisbericht.run.xml
del 000_Praxisbericht.toc
del 000_Praxisbericht-blx.bib