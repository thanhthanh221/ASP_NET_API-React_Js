import React, { useEffect, useState } from 'react'
import { useSelector, useDispatch } from 'react-redux'

import Button from '../Customs/Button'

import { remove } from '../../redux/product-modal/productModalSlice'
import ProductViewBackEnd from '../Product/ProductViewBackEnd'

const ProductViewModalBackEnd = () => {

    const productSlug = useSelector((state) => state.productModal.value)
    const dispatch = useDispatch()

    const [product, setProduct] = useState({})
    useEffect(() => {
        setProduct(productSlug);
    }, [productSlug]);

    return (
        <div className={`product-view__modal ${product === null ? '' : 'active'}`}>
            <div className="product-view__modal__content">
                {product === null ? '' : <ProductViewBackEnd product={product} />}
                <div className="product-view__modal__content__close">
                    <Button
                        size="sm"
                        onClick={() => dispatch(remove())}
                    >
                        đóng
                    </Button>
                </div>
            </div>
        </div>
    )
}

export default ProductViewModalBackEnd
