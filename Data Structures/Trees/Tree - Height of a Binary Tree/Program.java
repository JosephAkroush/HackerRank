static int height(Node root) {
    if (root == null) {
        return -1;
    }

    int heightLeft = height(root.left);
    int heightRight = height(root.right);

    if (heightLeft > heightRight) {
        return heightLeft + 1;
    } else {
        return heightRight + 1;
    }
}
