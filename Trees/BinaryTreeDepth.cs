namespace Trees {

    public class BinaryTreeDepth {

        public int MaxDepth(TreeNode root) {
            int max = 0;
            int count = 0;

            if (root.left != null) {
                count += 1;
                MaxDepth(root.left);
            } else if (root.right != null){
                count+= 1;
            }
    
            return max;
        }
    }

}