# Julian Sellanes (301494667)


# Week 4


# Exercise 1
print("\n======== Exercise 1 ========\n")

favorite_things = """
1. I love coding.
2. I enjoy playing chess.
3. I like making games in Unity.
"""

firstname = "Julian"
lastname = "Sellanes"
address = "1600 Pennsylvania Avenue, Washington, D.C"
print(f"Student Full Details:\nName: {firstname} {lastname}\nAddress: {address}")

# Exercise 2
print("\n======== Exercise 2 ========\n")

agile_software = ["Jira", "Trello", "Asana", "Scrumwise"]
agile_software.remove("Scrumwise")
print(agile_software[1:])

# Exercise 3
print("\n======== Exercise 3 ========\n")

courses = ["comp100", "comp120", "comp213"]
for course in courses:
    print(f"I am enrolled in {course}.")
courses.append("GNET")
print(courses)


# Week 5


# Exercise 4
print("\n======== Exercise 4 ========\n")

favorite_languages = {
    'jen': 'HTML',
    'sarah': 'c',
    'edward': 'ruby',
    'phil': 'C#',
}

favorite_languages['phil'] = 'Python'
favorite_languages['mike'] = 'JavaScript'
favorite_languages.pop('sarah')
print(list(favorite_languages.values()))

# Exercise 5
print("\n======== Exercise 5 ========\n")

student = {
    'name': 'Julian',
    'age': 21,
    'subject': 'Computer Science',
    'semester': 5,
    'grade': 'A',
    'lab': 'Data Structures',
}

print("Keys:", student.keys())
print("Values:", student.values())


# Week 6


# Exercise 6
print("\n======== Exercise 6 ========\n")

temperature = float(input("Enter the temperature: "))
if temperature < 98:
    print("Cold")
elif temperature > 98:
    print("Hot")
else:
    print("Normal")

# Exercise 7
print("\n======== Exercise 7 ========\n")

agile_values = ['Individuals and interactions', 'Working software', 'Customer collaboration', 'Responding to change']
for i in range(len(agile_values)):
    print(agile_values[i])


# Week 8


# Exercise 8
print("\n======== Exercise 8 ========\n")
def team_collaboration(software1, software2):
    print(f"I use {software1} software for team collaboration.")
    print(f"I use {software2} software for team collaboration.")

team_collaboration("Slack", "Microsoft Teams")

# Exercise 9
print("\n======== Exercise 9 ========\n")
project_id = 101

def project():
    global project_id
    project_id = 202
    internal_project_id = 303
    print(f"My global project id is: {project_id}")
    print(f"My internal project id is: {internal_project_id}")

project()
print(f"My global project id is: {project_id}")


# Week 9


# Exercise 10
print("\n======== Exercise 10 ========\n")
import calendar
print(calendar.month(2024, 10))

# Exercise 11
print("\n======== Exercise 11 ========\n")
import math
print(math.sqrt(16))        # Square root
print(math.factorial(5))    # Factorial
print(math.pow(2, 3))       # Power
print(math.ceil(4.3))       # Ceiling
print(math.floor(4.7))      # Floor

# Exercise 12
print("\n======== Exercise 12 ========\n")
import os

os.mkdir("example")
os.rmdir("example")


# Week 11


# Exercise 13
print("\n======== Exercise 13 ========\n")

script_dir = os.path.dirname(os.path.abspath(__file__))
file_path = os.path.join(script_dir, "pi_digits.txt")

with open(file_path, "r") as file:
    print(file.readline())

with open(file_path, "a") as file:
    file.write("\n1234567890")

with open(file_path, "r") as file:
    print(file.read())

print("\n")