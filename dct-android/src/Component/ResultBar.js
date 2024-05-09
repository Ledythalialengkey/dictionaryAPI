import * as React from 'react';
import { useState } from 'react';
import Button from 'react-bootstrap/Button';
import Form  from 'react-bootstrap/Form';
import Row  from 'react-bootstrap/Row';
import DropDowndct from './DropDowndct';

export default function ResultBar(props) {

  const [result, setResult] = useState({
    contentFrom: "",
    contentTo: "",
    contentAudio: "",
  });


  return (
    <Row className='mt-4 ps-4'>
        <Row>
            <div  className='mb-2' style={{paddingLeft:'0'}}>
              {props.from} 
              <Button className='btn-sm ms-2 btn-light ' style={{backgroundColor:'#fff', marginLeft:'0 !important',marginBottom:'0 !important'}}>
                <i class="bi bi-volume-down-fill"></i>
              </Button>              
            </div>            
            
            <DropDowndct setResult={setResult}/>
            
        </Row>
        
        <Row className='mt-3'>
            <div  className='mb-2' style={{paddingLeft:'0'}}>
              {props.to} 
              <Button className='btn-sm ms-2 btn-light ' style={{backgroundColor:'#fff', marginLeft:'0 !important',marginBottom:'0 !important'}}>
                <i class="bi bi-volume-down-fill"></i>
              </Button>              
            </div>            
            <Form.Control type='text' style={{height:'50px'}} value={result.contentTo}  />            
        </Row>        

        
    </Row>
  );
}