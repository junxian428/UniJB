// src/components/Timetable.js
import React from 'react';
import timetableData from './timetable.json';  // Adjust the path as necessary

const Timetable = () => {
  return (
    <div>
      <h1>Timetable</h1>
      {timetableData.map((daySchedule, index) => (
        <div key={index}>
          <h2>{daySchedule.day}</h2>
          <ul>
            {daySchedule.classes.map((classItem, idx) => (
              <li key={idx}>
                {classItem.time} - {classItem.subject}
              </li>
            ))}
          </ul>
        </div>
      ))}
    </div>
  );
};

export default Timetable;
