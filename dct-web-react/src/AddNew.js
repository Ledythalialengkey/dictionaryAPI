import Table from 'react-bootstrap/Table';
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';



function AddNew({ addNewVisibility }){
    return(
        <>
            <h4>Tambah Data</h4>
            <Table bordered  responsive className='mt-2'>
                <tbody>
                    <tr className='h-25'>
                        <td><Form.Control type='text' placeholder='indonesia'/></td>
                        <td><Form.Control type='text' placeholder='gorap'/></td>
                        <td><Form.Control type='file' placeholder='audio' controlId="formFile"
                            style={{ width: '150px' }}
                        /></td>
                        <td><Form.Control type='text' placeholder='deskripsi'/></td>
                        <td><Button onClick={addNewVisibility} className='btn-sm btn-light border'>Save</Button></td>
                    </tr>
                </tbody>
            </Table>
        </>
    );
}

export default AddNew;