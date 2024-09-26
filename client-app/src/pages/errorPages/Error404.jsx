import React from 'react';
import { useNavigate } from 'react-router-dom';

const Error404 = () => {
  const navigate = useNavigate();

  return (
    <div style={{ 
      textAlign: 'center', 
      padding: '50px', 
      height: '100vh', 
      display: 'flex', 
      flexDirection: 'column', 
      justifyContent: 'center', 
      alignItems: 'center',
      backgroundColor: '#e7e7c3'
    }}>
      <h1 style={{ 
        fontSize: '300px', 
        margin: '0 0 20px', 
        fontWeight: 'bold',
        backgroundImage: 'url(https://images.unsplash.com/photo-1506318137071-a8e063b4bec0?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1770&q=80)',
        backgroundClip: 'text',
        WebkitBackgroundClip: 'text',
        color: 'transparent',
        backgroundSize: 'cover',
        backgroundPosition: 'center',
      }}>
        Oops!
      </h1>
      <h2 style={{
        fontSize: '36px',
        margin: '0 0 30px',
        color: '#125831'
      }}>
        404 - PAGE NOT FOUND
      </h2>
      <p style={{
        fontSize: '18px',
        maxWidth: '600px',
        margin: '0 auto 40px',
        color: '#125831'
      }}>
        The page you are looking for might have been removed,
        had its name changed or is temporarily unavailable.
      </p>
      <button 
        style={{
          backgroundColor: '#007bff',
          color: 'white',
          padding: '12px 24px',
          border: 'none',
          borderRadius: '25px',
          cursor: 'pointer',
          fontSize: '18px',
          fontWeight: 'bold',
          boxShadow: '0 4px 6px rgba(0, 0, 0, 0.1)',
          transition: 'all 0.3s ease'
        }}
        onClick={() => navigate('/')}
        onMouseOver={(e) => e.target.style.backgroundColor = '#2a9fb9'}
        onMouseOut={(e) => e.target.style.backgroundColor = '#743939'}
      >
        GO TO HOMEPAGE
      </button>
    </div>
  );
};

export default Error404;