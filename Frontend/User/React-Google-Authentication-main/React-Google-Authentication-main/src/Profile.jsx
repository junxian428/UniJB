import React, { useState } from 'react';

function Profile({ profileDetails, login, logout }) {
  const [showButton, setShowButton] = useState(false);
  const toggleButton = () => {
    setShowButton(!showButton); // Toggle the state of showButton
  };

  const [showProfile, setShowProfile] = useState(false);
  const toggleProfile = () => {
    setShowProfile(!showProfile); // Toggle the state of showProfile
  };

  return (
    <div className='profile-container'>
      {profileDetails.length !== 0 ? (
        <div className="profile-details">
          <img
            src={profileDetails.picture}
            alt="Profile"
            className='profile-avatar'
            onClick={toggleProfile} // Toggle profile content on avatar click
          />

          {showProfile && (
            <div className="profile-content">
              <h3>{profileDetails.name}</h3>
              <h5>{profileDetails.email}</h5>
              <button className='profile-button' onClick={logout}>Logout</button>
            </div>
          )}

        </div>
      ) : (
        <div className="landing-container">
          <h2 onClick={toggleButton} onMouseEnter={() => setShowButton(true)}>
            Sign in
          </h2>
          {showButton && (
            <div>
            <button onClick={login}>Sign in with Google</button>
            <br></br>
            <button onClick={login}>Sign in with Facebook</button>

            </div>
          )}
        </div>
      )}
    </div>
  );
}

export default Profile;
