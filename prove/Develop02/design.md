# WDD230 Abstraction Program Design
## Journal Program

## Program Functions
- Write a new entry
- Display the journal
- Save the journal to a file
- Load the journal from a file
- Provide a menu for choices
- Have at least 5 prompts

## Classes
1. Program
    - Functions
        - Main Loop
            - Loop through Main Menu
                1. New Journal Entry
                2. Display Journal
                3. Save to File
                4. Load from File
                5. Exit
2. Journal
    - Variables
        - _entry (list,string)
            - date, prompt, response
        - _journal (list,entry)
    - Functions
        - NewEntry
            - Call prompter
            - Store Response as Entry
            - Add entry to journal
        - SaveJournal
            - Ask for File Name
            - Store Journal in JSON
        - LoadJournal
            - Ask for File Name
            - Clear Journal and load from JSON
        - Display
            - Display all entries from journal


3. Prompts
    - Variables
        - _date (string)
        - _prompt (string)
        - _response (string)
    - Functions
        - Prompter
            - Choose Prompt and Display
            - Recieve User Input
            - Save Reponse in Variables and Update Date