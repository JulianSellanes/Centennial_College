window.onload = function()
{
    let user = prompt("Please enter your name:");

    if(user)
    {
        let topSection = document.createElement('section');
        let title = document.createElement('h2');
        title.textContent = `Welcome ${user}`;

        topSection.appendChild(title);

        document.body.prepend(topSection);
    }
}

function showPrevCourses()
{
    let prevCourses = ['COMP100 - Programming I', 'MATH175 - Functions and Number Systems', 'COMP120 - Software Engineering Fundamentals', 'COMP213 - Web Interface Design', 'COMM161 - College Communications I', 'GNED137 - Wellness Approach'];
    let courseSection = document.getElementById('courses');
    let title = document.createElement('h2');
    let ul = document.createElement('ul');

    title.textContent = 'Previous Courses';
    prevCourses.forEach(x => {
        let li = document.createElement('li');
        li.textContent = x;
        ul.appendChild(li);
    });

    courseSection.appendChild(title);
    courseSection.appendChild(ul);
}

function updateTxtColor()
{
    document.getElementById('mission').style.color = 'red';
}

function addSkill()
{
    let list = document.getElementById('list');
    let react = document.createElement('li');
    react.textContent = 'React';
    list.insertBefore(react, list.firstChild);
}