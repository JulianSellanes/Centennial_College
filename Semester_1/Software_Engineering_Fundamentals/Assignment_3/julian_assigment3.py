# Julian Sellanes (301494667)


print("\n======== Question 1 ========\n")


# Creating a dictionary from the given table data
medals_dict = {
    "Canada": {"Gold": 2, "Silver": 0, "Bronze": 2},
    "OAR": {"Gold": 1, "Silver": 2, "Bronze": 0},
    "Japan": {"Gold": 1, "Silver": 1, "Bronze": 0},
    "China": {"Gold": 1, "Silver": 1, "Bronze": 0},
    "Germany": {"Gold": 1, "Silver": 0, "Bronze": 0}
}

# Displaying the results using a for loop
print("Medals Dictionary:")
for nation, medals in medals_dict.items():
    print(f"{nation}: Gold: {medals['Gold']}, Silver: {medals['Silver']}, Bronze: {medals['Bronze']}")

# Creating a list from the given table data
medals_list = [
    {"Nation": "Canada", "Gold": 2, "Silver": 0, "Bronze": 2},
    {"Nation": "OAR", "Gold": 1, "Silver": 2, "Bronze": 0},
    {"Nation": "Japan", "Gold": 1, "Silver": 1, "Bronze": 0},
    {"Nation": "China", "Gold": 1, "Silver": 1, "Bronze": 0},
    {"Nation": "Germany", "Gold": 1, "Silver": 0, "Bronze": 0}
]

# Displaying the results using a for loop
print("\nMedals List:")
for entry in medals_list:
    print(f"{entry['Nation']}: Gold: {entry['Gold']}, Silver: {entry['Silver']}, Bronze: {entry['Bronze']}")

# Understanding the difference between list and dictionary
understanding = """
A list is an ordered collection of items which can be of any type. Each item in a list has an index starting from zero.
Lists are mutable, meaning their elements can be changed after they are created.
Lists are useful when the order of elements matters and when you need to store a collection of items that can be accessed by their position.

A dictionary is an unordered collection of key-value pairs. Each key in a dictionary is unique and maps to a value.
Dictionaries are also mutable.
They are useful when you need to associate values with unique keys and when you need to quickly look up values based on their keys.

In summary:
- Lists are ordered collections accessed by index.
- Dictionaries are unordered collections accessed by key.
"""

print("\nUnderstanding the difference between list and dictionary:")
print(understanding)


print("\n======== Question 2 ========\n")


import csv

# Initialize a dictionary to store the sum of passing yards for each QB
qb_passing_yards = {}

# Open and read the CSV file
with open('nfl_offensive_stats.csv', 'r') as file:
    reader = csv.reader(file)
    next(reader)  # Skip the header row
    for row in reader:
        position = row[2]
        player = row[3]
        passing_yards = int(row[7])
        
        if position == "QB":
            if player in qb_passing_yards:
                qb_passing_yards[player] += passing_yards
            else:
                qb_passing_yards[player] = passing_yards

# Sort the QBs by sum of passing yards in descending order
sorted_qb_passing_yards = sorted(qb_passing_yards.items(), key=lambda x: x[1], reverse=True)

# Print the sum of the passing yards sorted by sum of passing yards in descending order
for player, yards in sorted_qb_passing_yards:
    print(f"{player}: {yards} passing yards")


print("\n======== Question 3 ========\n")


def is_strong_password(password):
    # Check if the password is either 'password' or 'qwerty'
    if password == "password" or password == "qwerty":
        return False
    return True

# Test cases
print(is_strong_password("password"))   # Expected output: False
print(is_strong_password("qwerty"))     # Expected output: False
print(is_strong_password("strongpass")) # Expected output: True


print("\n======== Question 4 ========\n")


def most_students(seat_rows):
    max_students = 0
    for row in seat_rows:
        empty_seats = row.count(' ')
        if empty_seats > max_students:
            max_students = empty_seats
    return max_students

# Example usage
seat_rows = [
    ['S', ' ', 'S', ' ', ' '],
    [' ', 'S', ' ', 'S', 'S'],
    ['S', 'S', ' ', ' ', ' '],
    [' ', ' ', 'S', ' ', 'S']
]

print(most_students(seat_rows))  # Output: 3
print()