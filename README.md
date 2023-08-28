# TypingRealm

The ultimate typing training tool.

## Project structure

`backend` - folder for backend services

### Library service

This project provides ability to maintain a library of typeable text.

**Folder:** `backend/library`

**Goals:**

- Allow import of books in txt format. It should strip all invalid formatting and index everything.
- Index all text and provide search capabilities:
    - Find all sentences where specific word is found (by word).
    - Find all words where specific letter combination is found (by two or three letters).
    - Find text by combinations of the previous two.
- Allow re-indexing of books for future use, when algorithms change or additional ways to search text are added.

The end goal is to have an extensive text library allowing to generate text based on user preferences, for example: user makes the most mistakes when typing `al` letters combinations, find and generate text with the most occurrence of `al`: `allegedly the mall was allocated at hall of Alladin`.

**Technologies:**

- postgresql for storage
