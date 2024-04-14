import React, { useState, useEffect} from 'react';
import Container from 'react-bootstrap/Container';
import Table from 'react-bootstrap/Table';
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';
import Row from 'react-bootstrap/Form';
import Col from 'react-bootstrap/Col';
import { Navbar } from 'react-bootstrap';
import AddNew from './AddNew';




function TableData() {
    const [isAddNew, setAddNew] = useState(false);
    
    const addNewVisibility = () => {
        setAddNew(!isAddNew);       
    };
    
    
    
    return (
        <Container className='mt-5'>
            <Button onClick={addNewVisibility} className='btn-sm'>
                {isAddNew ? 'Batal' : 'Tambah data'}
            </Button> <hr/>
           
            {isAddNew && <AddNew addNewVisibility={addNewVisibility}/>}
           

            <Row className='d-flex mb-2'>
                <Col sm ={8} ></Col>
                <Col sm ={4} >
                    <Form className='d-flex'>
                        <Form.Control type='text' className='mx-1' placeholder='cari kata' />
                        <Button className='btn-sm '>Cari </Button>
                    </Form>
                </Col>                
            </Row>
            
           
           

            <Table bordered hover responsive>
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Indonesia</th>
                        <th>Gorap</th>
                        <th>Audio</th>
                        <th>Deskripsi</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        {/* is ALL */}
                        {/* is By Search */}
                    </tr>
                </tbody>
            </Table>
        </Container>
    );
}

export default TableData;
