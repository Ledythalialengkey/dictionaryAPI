import * as React from 'react';
import { useState } from 'react';
import Col from 'react-bootstrap/Col';
import Row  from 'react-bootstrap/Row';
import './OptionBar.css'

export default function OptionsBar() {
  const [from, setFrom] = useState('Indonesia')
  const [to, setTo] = useState('Gorap') 

  // Switch values
  const switchValues = () => {
    setFrom((prevFrom) => prevFrom === 'Indonesia' ? 'Gorap' : 'Indonesia');
    setTo((prevTo) => prevTo === 'Gorap' ? 'Indonesia' : 'Gorap');
  };

  return (
    <Row className="pt-5" >                   
        <Col className='text-center'>
          <div className='p-1 box-rounded'>{from}</div>
        </Col>
        <Col className='text-center d-flex justify-content-center'>
            <div onClick={switchValues} className='p-1 box-center text-center '><i class="bi bi-arrow-left-right"/></div>
        </Col>
        <Col className='text-center'>
          <div className='p-1 box-rounded'>{to}</div>
        </Col>
      </Row>    
  );
}