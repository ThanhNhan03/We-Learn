import React, { createContext, useState, useEffect } from 'react';
import PropTypes from 'prop-types';  // Import prop-types for validation

export const UserContext = createContext();

export const UserProvider = ({ children }) => {
  const [User, setUser] = useState(() => {
    const storedUser = localStorage.getItem('User');
    return storedUser ? JSON.parse(storedUser) : null;
  });

  useEffect(() => { 
    if (User) {
      localStorage.setItem('User', JSON.stringify(User));
    } else {
      localStorage.removeItem('User');
    }
  }, [User]);

  const login = (userData) => {
    setUser(userData);
  }

  const logout = () => {
    setUser(null);
  }

  return (
    <UserContext.Provider value={{ User, login, logout }}>
      {children}
    </UserContext.Provider>
  );
};

// Add prop-types validation for 'children'
UserProvider.propTypes = {
  children: PropTypes.node.isRequired,
};